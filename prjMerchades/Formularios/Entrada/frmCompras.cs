using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using prjMerchades.Dados;
using prjMerchades.Dados.daDadosEntradaTableAdapters;
using prjMerchades.Dados.dsDadosSaidaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Entrada
{
    public partial class frmCompras : Form
    {
        private daDadosEntrada ds = new daDadosEntrada();
        private readonly string connStr = Properties.Settings.Default.masterConnectionString;

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daDadosEntrada2.infoNotaDividas' table. You can move, or remove it, as needed.
            this.infoNotaDividasTableAdapter.Fill(this.daDadosEntrada2.infoNotaDividas);
            // Carrega dados necessários
            this.fORNECEDORTableAdapter.Fill(this.daDadosEntrada.FORNECEDOR);
            //this.infoNotaDividasBindingSource.Fill(this.daDadosEntrada.infoNotaDividas);
            this.infoNotaTableAdapter1.Fill(this.daDadosEntrada.infoNota);
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada.compraDividas);
            this.comprasAntigasTableAdapter.Fill(this.daDadosEntrada.comprasAntigas);
            this.nOTA_FISCAL_FORNECEDORTableAdapter.Fill(this.daDadosEntrada.NOTA_FISCAL_FORNECEDOR);
            dateEmissao.Value = DateTime.Today;
        }

        bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCodNF.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtPreco.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCodBarras.Text)) return false;
            if (cmbTipoUnitario.SelectedIndex < 0) return false;
            if (numQtd.Value < 1) return false;

            return true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text) || !txtCodNF.MaskCompleted || string.IsNullOrEmpty(dateEmissao.Text))
            {
                MessageBox.Show("Informe todos os dados antes de prosseguir.");
                return;
            }

            // liberar campos de produto
            pnCamposItens.Visible = true;
            pnCamposItens.Enabled = true;
            lbl_VlrTtl.Visible = true;
            txtVlrTtl.Visible = true;
            btnAdd.Visible = true;
            btnCancelar.Visible = true;
            btnEnviar.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            int qtd = (int)numQtd.Value;
            decimal preco = decimal.Parse(txtPreco.Text);
            decimal total = preco * qtd;

            dtvwComprasNF.Rows.Add(
                txtCodBarras.Text,
                txtNomeProduto.Text,
                txtTipoProduto.Text,
                cmbTipoUnitario.Text,
                preco.ToString("F2"),
                qtd,
                total.ToString("F2")
            );

            // limpar parte do produto
            txtNomeProduto.Clear();
            txtCodBarras.Clear();
            txtTipoProduto.SelectedIndex = -1;
            txtPreco.Clear();
            cmbTipoUnitario.SelectedIndex = -1;
            numQtd.Value = 1;

            // Calcular total
            decimal somaTotal = 0;
            foreach (DataGridViewRow row in dtvwComprasNF.Rows)
            {
                somaTotal += Math.Round(Convert.ToDecimal(row.Cells["Coluna_total"].Value), 2);
            }
            txtVlrTtl.Text = "R$" + somaTotal.ToString("F2");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult acaoDoUsuario = MessageBox.Show("Deseja apagar o(s) produto(s) selecionados do carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (acaoDoUsuario == DialogResult.Yes)
            {
                int numDeItensSelecionados = dtvwComprasNF.SelectedRows.Count;

                if (numDeItensSelecionados == 0)
                {
                    MessageBox.Show("Nenhum item selecionado. Por favor selecione um item para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < numDeItensSelecionados; i++)
                {
                    dtvwComprasNF.Rows.RemoveAt(dtvwComprasNF.SelectedRows[0].Index);
                }

                decimal somaTotal = 0;
                foreach (DataGridViewRow row in dtvwComprasNF.Rows)
                {
                    somaTotal += Math.Round(Convert.ToDecimal(row.Cells["Coluna_total"].Value), 2);
                }
                txtVlrTtl.Text = "R$" + somaTotal.ToString("F2");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dtvwComprasNF.Rows.Count == 0)
            {
                MessageBox.Show("Adicione ao menos 1 item.");
                return;
            }

            // Validação de fornecedor
            if (!int.TryParse(txtCodFornecedor.SelectedValue?.ToString(), out int idFornecedor))
            {
                MessageBox.Show("Fornecedor inválido!");
                return;
            }

            // Verificar se fornecedor existe
            if (!FornecedorExiste(idFornecedor))
            {
                MessageBox.Show("Fornecedor não existe!");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente cadastrar essa nota fiscal?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                // Calcular total da NF
                decimal totalNF = 0;
                foreach (DataGridViewRow row in dtvwComprasNF.Rows)
                    totalNF += Convert.ToDecimal(row.Cells[6].Value);

                // 1. INSERIR NOTA FISCAL usando SQL direto
                int idNF = InserirNotaFiscal(dateEmissao.Value, totalNF, txtCodNF.Text, idFornecedor);
                MessageBox.Show($"Nota fiscal inserida com ID: {idNF}");

                // 2. PROCESSAR CADA PRODUTO
                foreach (DataGridViewRow row in dtvwComprasNF.Rows)
                {
                    string codBarras = row.Cells[0].Value.ToString();
                    string nome = row.Cells[1].Value.ToString();
                    string tipo = row.Cells[2].Value.ToString();
                    string unidade = row.Cells[3].Value.ToString();
                    decimal preco = Convert.ToDecimal(row.Cells[4].Value);
                    int qtd = Convert.ToInt32(row.Cells[5].Value);

                    // Verificar se produto já existe
                    int idProduto = VerificarProdutoExistente(codBarras);

                    if (idProduto > 0)
                    {
                        // Produto existe - ATUALIZAR
                        AtualizarProduto(idProduto, nome, tipo, unidade, preco, codBarras);
                    }
                    else
                    {
                        // Produto não existe - INSERIR NOVO
                        idProduto = InserirProduto(nome, tipo, unidade, preco, codBarras);
                    }

                    // Inserir na tabela ITENS_NOTA_FORNECEDOR (para trigger funcionar)
                    InserirItemNotaFornecedor(qtd, idProduto, idNF);
                }

                MessageBox.Show("Nota fiscal e produtos cadastrados com sucesso!");

                // Limpar interface
                dtvwComprasNF.Rows.Clear();
                txtVlrTtl.Text = "R$0,00";
                LimparCamposProduto();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO: {ex.Message}\n\nDetalhes: {ex.InnerException?.Message}", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== MÉTODOS SQL DIRETO ==========

        private bool FornecedorExiste(int idFornecedor)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM FORNECEDOR WHERE ID_FORNECEDOR = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idFornecedor);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private int InserirNotaFiscal(DateTime dataEmissao, decimal valor, string codNota, int idFornecedor)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO NOTA_FISCAL_FORNECEDOR 
                    (DATA_EMISSAO, VALOR_COMPRA, COD_NOTA_FORN, OBSERVACAO, ID_FORNECEDOR, PAGO)
                    VALUES (@data, @valor, @codNota, 'ENTRADA', @idFornecedor, 'N');";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@data", dataEmissao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@codNota", codNota);
                cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                cmd.ExecuteNonQuery();

                string selectSql = "SELECT IDENT_CURRENT('NOTA_FISCAL_FORNECEDOR');";
                SqlCommand selectCmd = new SqlCommand(selectSql, conn);
                return Convert.ToInt32(selectCmd.ExecuteScalar());
            }
        }

        private int VerificarProdutoExistente(string codBarras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT ID_PRODUTOS FROM PRODUTOS WHERE CODIGO_DE_BARRAS = @cod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", codBarras);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int InserirProduto(string nome, string tipo, string unidade, decimal preco, string codBarras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO PRODUTOS 
                    (NOME_PRODUTOS, TIPO_PRODUTOS, TIPO_UNITARIO, PRECO_PRODUTOS, CODIGO_DE_BARRAS)
                    OUTPUT INSERTED.ID_PRODUTOS
                    VALUES (@nome, @tipo, @unidade, @preco, @cod)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@unidade", unidade);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@cod", codBarras);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void AtualizarProduto(int idProduto, string nome, string tipo, string unidade, decimal preco, string codBarras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    UPDATE PRODUTOS SET
                        NOME_PRODUTOS = @nome,
                        TIPO_PRODUTOS = @tipo,
                        TIPO_UNITARIO = @unidade,
                        PRECO_PRODUTOS = @preco,
                        CODIGO_DE_BARRAS = @cod
                    WHERE ID_PRODUTOS = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@unidade", unidade);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@cod", codBarras);
                cmd.Parameters.AddWithValue("@id", idProduto);

                cmd.ExecuteNonQuery();
            }
        }

        private void InserirItemNotaFornecedor(int quantidade, int idProduto, int idNotaFiscal)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO ITENS_NOTA_FORNECEDOR 
                    (QTD_UNIT_PAC, ID_PRODUTOS, ID_NOTA_FISCAL_FORNEC)
                    VALUES (@qtd, @idProduto, @idNota)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qtd", quantidade);
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Parameters.AddWithValue("@idNota", idNotaFiscal);

                cmd.ExecuteNonQuery();
            }
        }

        private void LimparCamposProduto()
        {
            txtNomeProduto.Clear();
            txtCodBarras.Clear();
            txtTipoProduto.SelectedIndex = -1;
            txtPreco.Clear();
            cmbTipoUnitario.SelectedIndex = -1;
            numQtd.Value = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente cancelar o cadastro dessa compra? Todos os dados não enviados serão apagados.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            // Limpar tudo
            txtCodBarras.Clear();
            txtCodFornecedor.SelectedIndex = -1;
            txtCodNF.Clear();
            txtLote.Clear();
            txtVlrTtl.Text = "R$0,00";
            txtTipoProduto.SelectedIndex = -1;
            txtPreco.Clear();
            numQtd.Value = 1;
            cmbTipoUnitario.SelectedIndex = -1;
            dateValidade.ResetText();

            pnCamposItens.Visible = false;
            btnCancelar.Visible = false;
            btnEnviar.Visible = false;
            lbl_VlrTtl.Visible = false;
            txtVlrTtl.Visible = false;

            dtvwComprasNF.Rows.Clear();
        }

        private void btnBuscarDividas_Click(object sender, EventArgs e)
        {
            string coluna = cmbFiltroDividas.Text;
            string filtro = txtFiltroDividas.Text.Trim();
            string resultado = "";

            if (coluna == "Fornecedor")
            {
                resultado = $"NOME_FORNECEDOR LIKE '%{filtro}%'";
                infoNotaDividasBindingSource.Filter = resultado;
                return;
            }
            else if (coluna == "Valor")
            {
                filtro = filtro.Replace("R$", "").Trim();
                if (decimal.TryParse(filtro, out decimal valor))
                {
                    resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                    infoNotaDividasBindingSource.Filter = resultado;
                }
                else
                {
                    MessageBox.Show("Digite um valor válido.");
                }
                return;
            }
            else if (coluna == "Data")
            {
                DateTime datainicio = dateInicioDividas.Value.Date;
                DateTime datafim = dateFimDividas.Value.Date.AddDays(1);
                string inicioUS = datainicio.ToString("MM/dd/yyyy");
                string fimUS = datafim.ToString("MM/dd/yyyy");
                resultado = $"DATA_EMISSAO >= #{inicioUS}# AND DATA_EMISSAO < #{fimUS}#";
                infoNotaDividasBindingSource.Filter = resultado;
                return;
            }
            else if (coluna == "Nota fiscal")
            {
                resultado = $"COD_NOTA_FORN LIKE '%{filtro}%'";
                infoNotaDividasBindingSource.Filter = resultado;
                return;
            }
        }

        private void btnBuscarAntigas_Click(object sender, EventArgs e)
        {
            string coluna = cmbFiltroAntigas.Text;
            string filtro = txtFiltroAntigas.Text.Trim();
            string resultado = "";

            if (coluna == "Fornecedor")
            {
                resultado = $"NOME_FORNECEDOR LIKE '%{filtro}%'";
                infoNotaBindingSource.Filter = resultado;
                return;
            }
            else if (coluna == "Valor")
            {
                filtro = filtro.Replace("R$", "").Trim();
                if (decimal.TryParse(filtro, out decimal valor))
                {
                    resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                    infoNotaBindingSource.Filter = resultado;
                }
                else
                {
                    MessageBox.Show("Digite um valor válido.");
                }
                return;
            }
            else if (coluna == "Data")
            {
                DateTime datainicio = dateInicioAntigas.Value.Date;
                DateTime datafim = dateFimAntigas.Value.Date.AddDays(1);
                string inicioUS = datainicio.ToString("MM/dd/yyyy");
                string fimUS = datafim.ToString("MM/dd/yyyy");
                resultado = $"DATA_EMISSAO >= #{inicioUS}# AND DATA_EMISSAO < #{fimUS}#";
                infoNotaBindingSource.Filter = resultado;
                return;
            }
            else if (coluna == "Nota fiscal")
            {
                resultado = $"COD_NOTA_FORN LIKE '%{filtro}%'";
                infoNotaDividasBindingSource.Filter = resultado;
                return;
            }
        }

        private void numQtdACad_ValueChanged(object sender, EventArgs e)
        {
            if (numQtd.Value < 1)
            {
                MessageBox.Show("A quantidade mínima é 1.");
                numQtd.Value = 1;
                return;
            }
        }

        private void dataGridViewNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string idNota = dataGridViewNotasAntigas.Rows[e.RowIndex].Cells["COD_NOTA_FORN"].Value.ToString();
            this.infoProdutosTableAdapter1.Fill(this.daDadosEntrada.infoProdutos, idNota);
        }

        private void cmbFiltroAntigas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroAntigas.Text == "Data")
            {
                dateInicioAntigas.Visible = true;
                dateFimAntigas.Visible = true;
                lblInicioAntigas.Visible = true;
                lblFimAntigas.Visible = true;
                txtFiltroAntigas.Visible = false;
                lblFiltroAntigas.Visible = false;
            }
            else
            {
                dateInicioAntigas.Visible = false;
                dateFimAntigas.Visible = false;
                lblInicioAntigas.Visible = false;
                lblFimAntigas.Visible = false;
                txtFiltroAntigas.Visible = true;
                lblFiltroAntigas.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            infoNotaBindingSource.RemoveFilter();
            cmbFiltroAntigas.SelectedIndex = -1;
            txtFiltroAntigas.Text = "";
            dateInicioAntigas.Value = DateTime.Today;
            dateFimAntigas.Value = DateTime.Today;
            dateInicioAntigas.Visible = false;
            dateFimAntigas.Visible = false;
            txtFiltroAntigas.Visible = true;
            lblFiltroAntigas.Visible = true;
            MessageBox.Show("Filtros resetados");
        }

        private void cmbFiltroDividas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroDividas.Text == "Data")
            {
                dateInicioDividas.Visible = true;
                dateFimDividas.Visible = true;
                lblInicioDividas.Visible = true;
                lblFimDividas.Visible = true;
                txtFiltroDividas.Visible = false;
                lblFiltroDividas.Visible = false;
            }
            else
            {
                dateInicioDividas.Visible = false;
                dateFimDividas.Visible = false;
                lblInicioDividas.Visible = false;
                lblFimDividas.Visible = false;
                txtFiltroDividas.Visible = true;
                lblFiltroDividas.Visible = true;
            }
        }

        private void btnLimparDividas_Click(object sender, EventArgs e)
        {
            infoNotaDividasBindingSource.RemoveFilter();
            cmbFiltroDividas.SelectedIndex = -1;
            txtFiltroDividas.Text = "";
            dateInicioDividas.Value = DateTime.Today;
            dateFimDividas.Value = DateTime.Today;
            dateInicioDividas.Visible = false;
            dateFimDividas.Visible = false;
            txtFiltroDividas.Visible = true;
            lblFiltroDividas.Visible = true;
            MessageBox.Show("Filtros resetados.");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.infoNotaTableAdapter1.FillBy(this.daDadosEntrada.infoNota);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewNOtasDividas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string idNota = dataGridViewNOtasDividas.Rows[e.RowIndex].Cells["COD_NOTA_FORND"].Value.ToString();
            this.infoProdutosDividasTableAdapter.FillBy(this.daDadosEntrada.infoProdutosDividas, idNota);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewNOtasDividas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma nota fiscal.");
                return;
            }

            string idNota = dataGridViewNOtasDividas.CurrentRow.Cells["COD_NOTA_FORND"].Value.ToString();
            infoNotaDividasTableAdapter.UpdateNota(idNota);
            dataGridViewNOtasDividas.Rows.Remove(dataGridViewNOtasDividas.SelectedRows[0]);

            foreach (DataGridViewRow row in dataGridViewProdutosDividas.Rows)
            {
                dataGridViewProdutosDividas.Rows.Remove(row);
            }

            infoNotaDividasTableAdapter.Fill(daDadosEntrada.infoNotaDividas);
            infoNotaTableAdapter1.Fill(daDadosEntrada.infoNota);
            MessageBox.Show("Nota fiscal paga.");
        }
    }
}