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

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            // bgl pra dar cor pro botao "pagar"
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Habilitar scroll no painel de itens gerados (se ainda não estiver)
            pnCamposItens.AutoScroll = true; // Se pnCamposItens for o painel dinâmico

            // CAMPOS DE PRODUTO/AÇÃO (MANTER DESABILITADOS):
            pnCamposItens.Enabled = false; // O painel dos produtos dinâmicos
            txtVlrTtl.Enabled = false;
            btnCancelar.Enabled = false;
            btnEnviar.Enabled = false;

            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada3.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.comprasAntigas'. Você pode movê-la ou removê-la conforme necessário.
            this.comprasAntigasTableAdapter.Fill(this.daDadosEntrada3.comprasAntigas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada2.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada2.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada2.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada2.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada1.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada1.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada.NOTA_FISCAL_FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.nOTA_FISCAL_FORNECEDORTableAdapter.Fill(this.daDadosEntrada.NOTA_FISCAL_FORNECEDOR);
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Data2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["btn_pago"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                Rectangle rect = e.CellBounds;
                rect.Inflate(-4, -4);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 160, 80))) // verde
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    "Pagar",
                    new Font("Arial", 9, FontStyle.Bold),
                    rect,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex == dataGridView1.Columns["btn_pago"].Index)
            {
                MessageBox.Show("Pagamento realizado!");
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // --- 0. Validação Inicial e Fornecedor ---

            // 0a. Configuração do Fornecedor
            var fornecedorTA = new Dados.daDadosEntradaTableAdapters.FORNECEDORTableAdapter();
            fornecedorTA.Fill(daDadosEntrada.FORNECEDOR);

            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text) || string.IsNullOrWhiteSpace(txtCodNF.Text))
            {
                MessageBox.Show("Informe o Código do Fornecedor e o Código da Nota Fiscal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigoFornecedor = int.Parse(txtCodFornecedor.Text);

            // 0b. Verificação de Fornecedor
            var fornecedor = daDadosEntrada.FORNECEDOR.FindByID_FORNECEDOR(codigoFornecedor);
            if (fornecedor == null)
            {
                MessageBox.Show("O fornecedor informado nao existe, cadastre-o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var formCadastroFornecedor = new frmCadFornecedor();
                formCadastroFornecedor.MdiParent = this.MdiParent;
                formCadastroFornecedor.Show();
                return;
            }

            // --- 1. Calcular Valor Total e Agrupar Dados ---
            decimal valorTotalNota = 0;
            // O número de itens é o que o usuário definiu no NumericUpDown
            int qtdItens = (int)numQtdACad.Value;

            // Lista para armazenar temporariamente os dados de cada produto
            List<ProdutoData> produtosParaInserir = new List<ProdutoData>();

            // Iterar sobre a quantidade de produtos esperada (de 1 até qtdItens)
            for (int i = 1; i <= qtdItens; i++)
            {
                // Buscar os controles usando o nome gerado (ex: txtNomeProduto_1)
                TextBox txtNomeProduto = (TextBox)pnCamposItens.Controls.Find($"txtNomeProduto_{i}", true).FirstOrDefault();
                TextBox txtPreco = (TextBox)pnCamposItens.Controls.Find($"txtPreco_{i}", true).FirstOrDefault();
                NumericUpDown numQtd = (NumericUpDown)pnCamposItens.Controls.Find($"numQtd_{i}", true).FirstOrDefault();

                // Validação de campos essenciais
                if (txtNomeProduto == null || txtPreco == null || numQtd == null || string.IsNullOrWhiteSpace(txtNomeProduto.Text) || string.IsNullOrWhiteSpace(txtPreco.Text))
                {
                    MessageBox.Show($"Preencha Nome e Preço do Produto {i}.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação e cálculo
                if (!decimal.TryParse(txtPreco.Text, out decimal preco) || numQtd.Value <= 0)
                {
                    MessageBox.Show($"Preço ou Quantidade do Produto {i} é inválida.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int qtd = (int)numQtd.Value;
                valorTotalNota += preco * qtd;

                // Armazenar os dados de todos os campos
                produtosParaInserir.Add(new ProdutoData
                {
                    Nome = txtNomeProduto.Text,
                    Tipo = ((TextBox)pnCamposItens.Controls.Find($"txtTipoProduto_{i}", true).FirstOrDefault()).Text,
                    TipoUnitario = ((ComboBox)pnCamposItens.Controls.Find($"cmbTipoUnit_{i}", true).FirstOrDefault()).Text,
                    Preco = preco,
                    Qtd = qtd,
                    CodBarras = ((TextBox)pnCamposItens.Controls.Find($"txtCodBarras_{i}", true).FirstOrDefault()).Text,
                    Lote = ((TextBox)pnCamposItens.Controls.Find($"txtLote_{i}", true).FirstOrDefault()).Text,
                    DataValidade = ((DateTimePicker)pnCamposItens.Controls.Find($"dateValidade_{i}", true).FirstOrDefault()).Value
                });
            }

            // --- 2. Insert na tabela de Nota Fiscal ---
            var notaFiscalFornecedor = new Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter();

            // Atualiza o campo Valor Total na tela
            txtVlrTtl.Text = valorTotalNota.ToString("N2");

            notaFiscalFornecedor.Insert(
                dateEmissao.Value,
                (int)valorTotalNota,
                txtCodNF.Text,
                // Usando o tipo do primeiro produto ou uma string padrão, pois este campo existe na sua NF.
                produtosParaInserir.FirstOrDefault()?.Tipo ?? "Diverso",
                codigoFornecedor,
                "n"
            );

            int idNF = int.Parse(notaFiscalFornecedor.ultimoId().ToString());

            // --- 3. Insert em Produtos e Estoque (Loop) ---
            var produtosTA = new Dados.daDadosEntradaTableAdapters.PRODUTOSEntradaTableAdapter();
            var estoqueTA = new Dados.daDadosEntradaTableAdapters.ESTOQUEEntradaTableAdapter();

            foreach (var item in produtosParaInserir)
            {
                // Insert na tabela produto
                produtosTA.Insert(
                    item.Nome,
                    item.Tipo,
                    item.TipoUnitario,
                    item.Preco,
                    // Garante que o Codigo de Barras seja um número válido antes de tentar o Parse
                    int.TryParse(item.CodBarras, out int codBarras) ? codBarras : 0
                );

                int idProduto = int.Parse(produtosTA.ultimoId().ToString());

                // Insert na tabela estoque
                estoqueTA.Insert(item.Qtd, idProduto, idNF);
            }

            // --- 4. Finalização ---
            MessageBox.Show("Entrada cadastrada com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar_Click(sender, e); // Chama a função Cancelar para limpar os campos

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string coluna, filtro, resultado;

            coluna = cmbFiltro.Text; //qual coluna da tabela sera aplicado o filtro
            filtro = txtFiltro.Text; //filtragem

            if (coluna == "Fornecedor") 
            {
                resultado = "NOME_FORNECEDOR like '%" + filtro + "%'";
                compraDividasBindingSource.Filter = resultado;
            }

            else if (coluna == "Data")
            {
                resultado = $"Convert(DATA_EMISSAO, 'System.String') LIKE '%{filtro}%'";
                compraDividasBindingSource.Filter = resultado;
            }

            if (coluna == "Valor")
            {
                resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                compraDividasBindingSource.Filter = resultado;
            }
        }

        private void btnBuscarAntigas_Click(object sender, EventArgs e)
        {
            string coluna, filtro, resultado;

            coluna = cmbFiltroAntigas.Text;
            filtro = txtFiltroAntigas.Text;

            if (coluna == "Fornecedor")
            {
                resultado = "NOME_FORNECEDOR like '%" + filtro + "%'";
                comprasAntigasBindingSource.Filter = resultado;
            }

            else if (coluna == "Data")
            {
                resultado = $"Convert(DATA_EMISSAO, 'System.String') LIKE '%{filtro}%'";
                comprasAntigasBindingSource.Filter = resultado;
            }

            if (coluna == "Valor")
            {
                resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                comprasAntigasBindingSource.Filter = resultado;
            }
        }

        // Adicione esta classe auxiliar no arquivo frmCompras.cs, FORA da classe frmCompras
       

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int qtd = (int)numQtdACad.Value;

            if (qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            pnCamposItens.Controls.Clear();

            // Habilita APENAS o painel completo para interação com os itens gerados
            pnCamposItens.Enabled = true;

            // Desabilita os controles de controle para evitar re-geração
            numQtdACad.Enabled = false;
            btnGerar.Enabled = false;

            // Habilita os botões de ação final
            btnEnviar.Enabled = true;
            btnCancelar.Enabled = true;

            GerarCamposProdutos(qtd);
        }

        private void GerarCamposProdutos(int quantidade)
        {
            int posY = 20;

            for (int i = 1; i <= quantidade; i++)
            {
                // Criar bloco e obter altura usada
                int blocoAltura = CriarBlocoProduto(i, posY);
                posY += blocoAltura;

                // Linha divisória (copiado do seu código anterior)
                Label divisoria = new Label();
                divisoria.Text = "________________________________________________________________________________________________________________________";
                divisoria.ForeColor = Color.FromArgb(165, 165, 165);
                divisoria.AutoSize = true;
                divisoria.Location = new Point(20, posY);
                divisoria.Width = Math.Max(100, pnCamposItens.ClientSize.Width - 40);
                divisoria.Top = posY + 8;
                divisoria.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                pnCamposItens.Controls.Add(divisoria);

                posY += 45; // espaço entre blocos
            }
        }

        /// <summary>
        /// Cria um bloco de campos para um produto.
        /// Retorna a altura ocupada pelo bloco (para posicionamento do próximo).
        /// </summary>
        private int CriarBlocoProduto(int indice, int posY)
        {
            int marginLeft = 40;
            int currentY = posY;

            // Título do produto (Produto 1, Produto 2, etc.)
            Label lblTitulo = new Label();
            lblTitulo.Text = $"Produto {indice}";
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(112, 78, 46);
            lblTitulo.Location = new Point(marginLeft, currentY);
            pnCamposItens.Controls.Add(lblTitulo);

            currentY += 36; // mover para a linha dos campos

            // Linha 1: Nome Produto, Tipo de Produto, Preço, Quantidade

            // Nome Produto
            Label lblNomeProduto = new Label();
            lblNomeProduto.Text = "Nome Produto:";
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblNomeProduto.ForeColor = Color.FromArgb(112, 78, 46);
            lblNomeProduto.Location = new Point(marginLeft, currentY);
            pnCamposItens.Controls.Add(lblNomeProduto);

            TextBox txtNomeProduto = new TextBox();
            txtNomeProduto.Location = new Point(marginLeft, currentY + 30);
            txtNomeProduto.Size = new Size(300, 26);
            txtNomeProduto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            txtNomeProduto.Name = $"txtNomeProduto_{indice}"; // Chave para identificação
            pnCamposItens.Controls.Add(txtNomeProduto);

            // Tipo de Produto
            Label lblTipoProduto = new Label();
            lblTipoProduto.Text = "Tipo de Produto:";
            lblTipoProduto.AutoSize = true;
            lblTipoProduto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTipoProduto.ForeColor = Color.FromArgb(112, 78, 46);
            lblTipoProduto.Location = new Point(marginLeft + 340, currentY);
            pnCamposItens.Controls.Add(lblTipoProduto);

            TextBox txtTipoProduto = new TextBox();
            txtTipoProduto.Location = new Point(marginLeft + 340, currentY + 30);
            txtTipoProduto.Size = new Size(220, 26);
            txtTipoProduto.Name = $"txtTipoProduto_{indice}"; // Chave para identificação
            pnCamposItens.Controls.Add(txtTipoProduto);

            // Preço 
            Label lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblPreco.ForeColor = Color.FromArgb(112, 78, 46);
            lblPreco.Location = new Point(marginLeft + 580, currentY);
            pnCamposItens.Controls.Add(lblPreco);

            TextBox txtPreco = new TextBox();
            txtPreco.Location = new Point(marginLeft + 580, currentY + 30);
            txtPreco.Size = new Size(120, 26);
            txtPreco.Name = $"txtPreco_{indice}"; // Chave para identificação
            pnCamposItens.Controls.Add(txtPreco);

            // Quantidade
            Label lblQtd = new Label();
            lblQtd.Text = "Qtd:";
            lblQtd.AutoSize = true;
            lblQtd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblQtd.ForeColor = Color.FromArgb(112, 78, 46);
            lblQtd.Location = new Point(marginLeft + 730, currentY);
            pnCamposItens.Controls.Add(lblQtd);

            NumericUpDown numQtd = new NumericUpDown();
            numQtd.Minimum = 1;
            numQtd.Maximum = 9999;
            numQtd.Location = new Point(marginLeft + 730, currentY + 30);
            numQtd.Width = 90;
            numQtd.Name = $"numQtd_{indice}"; // Chave para identificação
            pnCamposItens.Controls.Add(numQtd);

            // Próxima linha
            currentY += 80;

            // Linha 2: Data de Validade, Tipo Unitário, Código de Barras, Lote

            // Data de Validade
            Label lblValidade = new Label();
            lblValidade.Text = "Data de Validade:";
            lblValidade.AutoSize = true;
            lblValidade.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblValidade.ForeColor = Color.FromArgb(112, 78, 46);
            lblValidade.Location = new Point(marginLeft, currentY);
            pnCamposItens.Controls.Add(lblValidade);

            DateTimePicker dateValidade = new DateTimePicker();
            dateValidade.Format = DateTimePickerFormat.Short;
            dateValidade.Location = new Point(marginLeft, currentY + 30);
            dateValidade.Name = $"dateValidade_{indice}"; // Chave para identificação
            dateValidade.MinDate = DateTime.Today;
            pnCamposItens.Controls.Add(dateValidade);

            // Tipo Unitário
            Label lblTipoUnit = new Label();
            lblTipoUnit.Text = "Tipo Unitário:";
            lblTipoUnit.AutoSize = true;
            lblTipoUnit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTipoUnit.ForeColor = Color.FromArgb(112, 78, 46);
            lblTipoUnit.Location = new Point(marginLeft + 240, currentY);
            pnCamposItens.Controls.Add(lblTipoUnit);

            ComboBox cmbTipoUnit = new ComboBox();
            cmbTipoUnit.Location = new Point(marginLeft + 240, currentY + 30);
            cmbTipoUnit.Width = 220;
            cmbTipoUnit.Name = $"cmbTipoUnit_{indice}"; // Chave para identificação
            cmbTipoUnit.Items.AddRange(new[] { "kg", "un", "cx" });
            pnCamposItens.Controls.Add(cmbTipoUnit);

            // Código de Barras
            Label lblCodigo = new Label();
            lblCodigo.Text = "Código de Barras:";
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(112, 78, 46);
            lblCodigo.Location = new Point(marginLeft + 490, currentY);
            pnCamposItens.Controls.Add(lblCodigo);

            TextBox txtCodigo = new TextBox();
            txtCodigo.Location = new Point(marginLeft + 490, currentY + 30);
            txtCodigo.Width = 220;
            txtCodigo.Name = $"txtCodBarras_{indice}"; // Chave para identificação
            txtCodigo.Text = txtCodBarras.Text; // Pode preencher com o código de barras inicial da NF, se for o mesmo
            pnCamposItens.Controls.Add(txtCodigo);

            // Lote
            Label lblLote = new Label();
            lblLote.Text = "Lote:";
            lblLote.AutoSize = true;
            lblLote.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblLote.ForeColor = Color.FromArgb(112, 78, 46);
            lblLote.Location = new Point(marginLeft + 740, currentY);
            pnCamposItens.Controls.Add(lblLote);

            TextBox txtLote = new TextBox();
            txtLote.Location = new Point(marginLeft + 740, currentY + 30);
            txtLote.Width = 140;
            txtLote.Name = $"txtLote_{indice}"; // Chave para identificação
            pnCamposItens.Controls.Add(txtLote);

            // altura total ocupada pelo bloco
            int alturaTotalDoBloco = (currentY + 30) - posY + 10; // Linha 2 + margem
            return alturaTotalDoBloco;
        
    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnCamposItens.Controls.Clear();

            // Desabilita o painel de itens
            pnCamposItens.Enabled = false;

            numQtdACad.Value = 1;

            // MODIFICAÇÃO CHAVE: LIMPAR CAMPOS, MAS MANTER HABILITADOS
            txtCodFornecedor.Text = ""; // Limpa os campos
            txtCodNF.Text = "";
            // txtCodBarras.Text = ""; // Limpar Código de Barras
            txtVlrTtl.Text = "";

            // Habilita os controles de controle
            numQtdACad.Enabled = true;
            btnGerar.Enabled = true;

            // Desabilita botões de ação final
            btnCancelar.Enabled = false;
            btnEnviar.Enabled = false;
        }
    }
    public class ProdutoData
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
        public int Qtd { get; set; }
        public DateTime DataValidade { get; set; }
        public string TipoUnitario { get; set; }
        public string CodBarras { get; set; }
        public string Lote { get; set; }
    }
}
