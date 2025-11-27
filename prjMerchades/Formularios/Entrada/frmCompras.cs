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
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.comprasAntigas'. Você pode movê-la ou removê-la conforme necessário.
            this.comprasAntigasTableAdapter.Fill(this.daDadosEntrada.comprasAntigas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada2.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.nOTA_FISCAL_FORNECEDORTableAdapter.Fill(this.daDadosEntrada.NOTA_FISCAL_FORNECEDOR);
            dtvwComprasNF.AutoGenerateColumns = true;
            dtvwComprasNF.DataSource = ds.PRODUTOSEntrada; // tabela do XSD
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Data2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dateEmissao.Value = DateTime.Today;
            dateEmissao.Enabled = false;
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
            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text))
            {
                MessageBox.Show("Informe o código do fornecedor.");
                return;
            }

            // gera NF automática
            string prefixo = DateTime.Today.ToString("MMdd");

            var notaTA = new NOTA_FISCAL_FORNECEDORTableAdapter();
            int seq = GetSequenciaNF(notaTA, prefixo);

            txtCodNF.Text = $"NF{prefixo}-{seq:0000}";
            dateEmissao.Value = DateTime.Today;

            // liberar campos de produto
            txtNomeProduto.Enabled = true;
            txtCodBarras.Enabled = true;
            numQtd.Enabled = true;
            dateValidade.Enabled = true;
            txtTipoProduto.Enabled = true;
            txtPreco.Enabled = true;
            numQtdACad.Enabled = true;
            cmbTipoUnitario.Enabled = true;
            txtLote.Enabled = true;
            btnAdd.Enabled = true;
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
            txtTipoProduto.Clear();
            txtPreco.Clear();
            cmbTipoUnitario.SelectedIndex = -1;
            numQtd.Value = 1;
        }

        private int GetSequenciaNF(NOTA_FISCAL_FORNECEDORTableAdapter ta, string prefixo)
        {
            var dt = ta.GetData();
            string like = $"NF{prefixo}-";
            int maior = 0;

            foreach (DataRow r in dt.Rows)
            {
                if (r["COD_NF"] == DBNull.Value) continue;

                string cod = r["COD_NF"].ToString();
                if (!cod.StartsWith(like)) continue;

                string[] partes = cod.Split('-');
                if (partes.Length == 2 && int.TryParse(partes[1], out int seq))
                {
                    if (seq > maior) maior = seq;
                }
            }

            return maior + 1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dtvwComprasNF.Rows.Count == 0)
            {
                MessageBox.Show("Adicione ao menos 1 item.");
                return;
            }

            var notaTA = new NOTA_FISCAL_FORNECEDORTableAdapter();
            var produtosTA = new PRODUTOSEntradaTableAdapter();
            var estoqueTA = new ESTOQUEEntradaTableAdapter();
            var fornecedorTA = new FORNECEDORTableAdapter();

            int idFornecedor = int.Parse(txtCodFornecedor.Text);

            fornecedorTA.Fill(daDadosEntrada.FORNECEDOR);
            if (daDadosEntrada.FORNECEDOR.FindByID_FORNECEDOR(idFornecedor) == null)
            {
                MessageBox.Show("Fornecedor não existe!");
                return;
            }

            decimal totalNF = 0;
            foreach (DataGridViewRow row in dtvwComprasNF.Rows)
                totalNF += Convert.ToDecimal(row.Cells[6].Value);

            // inserir NF
            notaTA.Insert(
                dateEmissao.Value,
                totalNF,
                txtCodNF.Text,
                "ENTRADA",
                idFornecedor,
                "n"
            );

            int idNF = GetMaxId("NOTA_FISCAL_FORNECEDOR", "ID_NOTA_FISCAL");

            // carrega tabelas
            var tabelaProd = produtosTA.GetData();
            var tabelaEstoque = estoqueTA.GetData();

            foreach (DataGridViewRow row in dtvwComprasNF.Rows)
            {
                int codBarras = int.Parse(row.Cells[0].Value.ToString());
                string nome = row.Cells[1].Value.ToString();
                string tipo = row.Cells[2].Value.ToString();
                string unidade = row.Cells[3].Value.ToString();
                decimal preco = Convert.ToDecimal(row.Cells[4].Value);
                int qtd = Convert.ToInt32(row.Cells[5].Value);

                var prodExist =
                    tabelaProd.FirstOrDefault(r => r.CODIGO_DE_BARRAS == codBarras);

                int idProduto;

                if (prodExist != null)
                {
                    idProduto = prodExist.ID_PRODUTOS;

                    // atualiza produto via SQL
                    UpdateProdutoDireto(idProduto, nome, tipo, unidade, preco, codBarras);

                    // soma estoque via SQL
                    SomarQuantidadeEstoque(idProduto, qtd, idNF);
                }
                else
                {
                    // insere produto
                    produtosTA.Insert(nome, tipo, unidade, preco, codBarras);

                    idProduto = GetMaxId("PRODUTOSEntrada", "ID_PRODUTO");

                    // novo estoque
                    estoqueTA.Insert(qtd, idProduto, idNF);
                }
            }

            MessageBox.Show("Entrada cadastrada com sucesso!");
            dtvwComprasNF.Rows.Clear();
        }


        private int GetMaxId(string tabela, string coluna)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = $"SELECT ISNULL(MAX({coluna}), 0) FROM {tabela}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int MaxId(SqlConnection conn, string tabela, string colunaId)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sql = $"SELECT ISNULL(MAX({colunaId}), 0) FROM {tabela}";

            SqlCommand cmd = new SqlCommand(sql, conn);
            int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());

            return ultimoId;
        }

        private void UpdateProdutoDireto(int idProduto, string nome, string tipo, string unidade, decimal preco,int codBarras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"
            UPDATE PRODUTOSEntrada SET
                NOME_PRODUTO = @nome,
                TIPO_PRODUTO = @tipo,
                UNIDADE = @unidade,
                PRECO = @preco,
                CODIGO_DE_BARRAS = @cod
            WHERE ID_PRODUTO = @idProd";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@unidade", unidade);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@cod", codBarras);
                cmd.Parameters.AddWithValue("@idProd", idProduto);

                cmd.ExecuteNonQuery();
            }
        }

        private void SomarQuantidadeEstoque(int idProduto, int qtd, int idNF)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // primeiro tenta atualizar
                string sqlUpdate = @"
            UPDATE ESTOQUEEntrada
            SET QTD_ESTOQUE_ADDED = QTD_ESTOQUE_ADDED + @qtd
            WHERE ID_PRODUTOS = @idProd";

                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@idProd", idProduto);

                int afetou = cmd.ExecuteNonQuery();

                if (afetou == 0)
                {
                    // não existia → insere novo registro
                    string sqlInsert = @"
                INSERT INTO ESTOQUEEntrada (QTD_ESTOQUE_ADDED, ID_PRODUTOS, ID_NOTA_FISCAL)
                VALUES (@qtd, @idProd, @idNF)";

                    SqlCommand insert = new SqlCommand(sqlInsert, conn);
                    insert.Parameters.AddWithValue("@qtd", qtd);
                    insert.Parameters.AddWithValue("@idProd", idProduto);
                    insert.Parameters.AddWithValue("@idNF", idNF);

                    insert.ExecuteNonQuery();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            string coluna = cmbFiltro.Text; //qual coluna da tabela sera aplicado o filtro
            string filtro = txtFiltro.Text.Trim(); //filtragem
            string resultado = "";

            if (coluna == "Fornecedor")
            {
                resultado = $"NOME_FORNECEDOR LIKE '%{filtro}%'";
                compraDividasBindingSource.Filter = resultado;
                return;
            }

            else if (coluna == "Valor")
            {
                filtro = filtro.Replace("R$", "").Trim(); //tira os caracteres

                if (decimal.TryParse(filtro, out decimal valor))
                {
                    resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                    compraDividasBindingSource.Filter = resultado;
                }
                else
                {
                    MessageBox.Show("Digite um valor válido.");
                }

                return;
            }

            else if (coluna == "Data")
            {
                if (!DateTime.TryParse(filtro, out DateTime dataFiltro))
                {
                    MessageBox.Show("Digite uma data no formato dd/mm/yyyy");
                    return;
                }
                
                DateTime inicio = dataFiltro.Date; //deixa zerado as horas da data
                DateTime fim = inicio.AddDays(1); //add 1 dia

                //a data ta no formato americano, aqui ele converte e faz com que pegue as 24h do dia
                string inicioUS = inicio.ToString("MM/dd/yyyy");
                string fimUS = fim.ToString("MM/dd/yyyy");

                resultado = $"DATA_EMISSAO >= #{inicioUS}# AND DATA_EMISSAO < #{fimUS}#"; // o filtro acaba pegando as 24h do dia digitado

                compraDividasBindingSource.Filter = resultado;
                return;
            }
        }

        private void btnBuscarAntigas_Click(object sender, EventArgs e)
        {
            string coluna = cmbFiltroAntigas.Text; //qual coluna da tabela sera aplicado o filtro
            string filtro = txtFiltroAntigas.Text.Trim(); //filtragem
            string resultado = "";

            if (coluna == "Fornecedor")
            {
                resultado = $"NOME_FORNECEDOR LIKE '%{filtro}%'";
                comprasAntigasBindingSource.Filter = resultado;
                return;
            }

            else if (coluna == "Valor")
            {
                filtro = filtro.Replace("R$", "").Trim(); //tira os caracteres

                if (decimal.TryParse(filtro, out decimal valor))
                {
                    resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                    comprasAntigasBindingSource.Filter = resultado;
                }
                else
                {
                    MessageBox.Show("Digite um valor válido.");
                }

                return;
            }

            else if (coluna == "Data")
            {
                if (!DateTime.TryParse(filtro, out DateTime dataFiltro))
                {
                    MessageBox.Show("Digite uma data no formato dd/mm/yyyy");
                    return;
                }


                DateTime inicio = dataFiltro.Date; //deixa zerado as horas da data
                DateTime fim = inicio.AddDays(1);

                //a data ta no formato americano, aqui ele converte e faz com que pegue as 24h do dia
                string inicioUS = inicio.ToString("MM/dd/yyyy");
                string fimUS = fim.ToString("MM/dd/yyyy");

                resultado = $"DATA_EMISSAO >= #{inicioUS}# AND DATA_EMISSAO < #{fimUS}#"; // o filtro acaba pegando as 24h do dia digitado

                comprasAntigasBindingSource.Filter = resultado;
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
    }
}
