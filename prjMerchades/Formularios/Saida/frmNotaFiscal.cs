using prjMerchades.Formularios;
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

namespace Merchades
{
    public partial class frmNotaFiscal : Form
    {
        public frmNotaFiscal()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado
        }

        //=====================================CARREGA CADA NOTA FISCAL NO PAINEL DA DIREITA=====================================

        //Cria a conexão com o banco com base na variável de ambiente
        string connectionString = prjMerchades.Properties.Settings.Default.db_240098_66_A_1_2024ConnectionString;
        private void frmNotaFiscal_Load(object sender, EventArgs e)
        {
            CarregarNotasFiscaisComFiltro();
        }

        //Varíavel global da função que serve para somar o total do valor de todos os itens do pedido
        decimal valorTotalProdutos = 0;

        private void MostrarVenda(int id)
        {

            string queryDadosGerais = "SELECT N.COD_NOTA_VENDA, N.DATA_EMISSAO, N.QTD_PARCELAS, N.CPF_CNPJ_VENDA FROM NOTA_FISCAL_VENDA N INNER JOIN CLIENTE C ON C.CPF_CNPJ_CLIENTE = N.CPF_CNPJ_VENDA WHERE N.ID_NOTA_VENDA = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //=============================DADOS GERAIS DA VENDA=============================//
                using (SqlCommand cmd = new SqlCommand(queryDadosGerais, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string codNota = dr.GetString(0);
                        DateTime emissao = dr.GetDateTime(1);
                        int parcelas = dr.GetInt32(2);
                        string cpf = dr.GetString(3);

                        // Mostra os elementos gerais da venda
                        lblLabelId.Visible = true;
                        lblIdNF.Visible = true;
                        lblLabelDataEmissao.Visible = true;
                        lblDataEmissaoNF.Visible = true;
                        lblLabelCpf.Visible = true;
                        lblCpfNF.Visible = true;

                        lblTituloDetalhes.Text = $"Venda {codNota}";
                        lblIdNF.Text = id.ToString();
                        lblDataEmissaoNF.Text = emissao.ToString();
                        lblCpfNF.Text = cpf;

                        if (parcelas > 1)
                        {
                            lblLabelParcelas.Visible = true;
                            lblValorParcelas.Visible = true;
                            lblValorParcelas.Text = parcelas.ToString();
                        }
                        else
                        {
                            lblLabelParcelas.Visible = false;
                            lblValorParcelas.Visible = false;
                        }
                    }
                    dr.Close();
                }



                //=============================DADOS DOS PRODUTOS DA VENDA=============================//
                string queryDadosProdutos = "SELECT PRODUTOS.NOME_PRODUTOS, ITENS.QTD_PRODUTO, PRODUTOS.PRECO_PRODUTOS, ITENS.ID_NOTA_VENDA FROM ITENS_NOTA_VENDA ITENS INNER JOIN PRODUTOS ON ITENS.ID_PRODUTOS = PRODUTOS.ID_PRODUTOS WHERE ITENS.ID_NOTA_VENDA = @id";

                using (SqlCommand cmdProdutos = new SqlCommand(queryDadosProdutos, con))
                {
                    cmdProdutos.Parameters.AddWithValue("@id", id);

                    SqlDataReader drProdutos = cmdProdutos.ExecuteReader();

                    // Limpa produtos anteriores (se houver)
                    LimparProdutosAnteriores();

                    int linha = 0; //Indica a linha atual que está sendo escrita
                    int alturaLinha = 50; // Altura de cada linha de produto
                    int posicaoYBase = 17; // Posição Y base para a primeira linha

                    while (drProdutos.Read())
                    {
                        string nomeProduto = drProdutos.GetString(0);
                        int quantidade = drProdutos.GetInt32(1);
                        decimal preco = drProdutos.GetDecimal(2);

                        // Calcula a posição Y para esta linha
                        int posicaoY = posicaoYBase + (linha * alturaLinha);

                        // Cria os controles para este produto
                        CriarControlesProduto(nomeProduto, quantidade, preco, posicaoY, linha);

                        linha++;
                        valorTotalProdutos += preco * quantidade;
                    }

                    drProdutos.Close();
                }
                lblLabelValorTotal.Visible = true;
                lblValorTotalNF.Visible = true;
                lblValorTotalNF.Text = "R$ " + valorTotalProdutos.ToString("N2");
            }
        }

        private void LimparProdutosAnteriores()
        {
            // Remove apenas os controles dinâmicos de produtos
            // Você pode identificar eles por Tag ou por Name específico
            var controlesParaRemover = new List<Control>();

            foreach (Control control in pnDetalheslProdutos.Controls)
            {
                if (control.Tag?.ToString() == "produto_dinamico")
                {
                    controlesParaRemover.Add(control);
                }
            }

            foreach (Control control in controlesParaRemover)
            {
                pnDetalheslProdutos.Controls.Remove(control);
                control.Dispose();
            }

            valorTotalProdutos = 0;
        }

        private void CriarControlesProduto(string nomeProduto, int quantidade, decimal preco, int posicaoY, int linhaIndex)
        {
            // Label do nome do produto
            Label lblNomeProduto = new Label();
            lblNomeProduto.Text = "Produto:";
            lblNomeProduto.Location = new Point(16, posicaoY);
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.ForeColor = Color.White;
            lblNomeProduto.Tag = "produto_dinamico";
            lblNomeProduto.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblNomeProduto);

            // Campo com valor do produto (nome)
            Label lblValorNome = new Label();
            lblValorNome.Text = nomeProduto;
            lblValorNome.Location = new Point(98, posicaoY);
            lblValorNome.Size = new Size(289, 25);
            lblValorNome.ForeColor = Color.White;
            lblValorNome.BackColor = Color.FromArgb(138, 148, 144);
            lblValorNome.FlatStyle = FlatStyle.Flat;
            lblValorNome.Tag = "produto_dinamico";
            lblValorNome.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblValorNome);

            // Label de quantidade
            Label lblQuantidade = new Label();
            lblQuantidade.Text = "Qtd:";
            lblQuantidade.Location = new Point(397, posicaoY);
            lblQuantidade.AutoSize = true;
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Tag = "produto_dinamico";
            lblQuantidade.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblQuantidade);

            // Campo com valor da quantidade
            Label lblValorQuantidade = new Label();
            lblValorQuantidade.Text = quantidade.ToString();
            lblValorQuantidade.Location = new Point(445, posicaoY);
            lblValorQuantidade.Size = new Size(88, 25);
            lblValorQuantidade.ForeColor = Color.White;
            lblValorQuantidade.BackColor = Color.FromArgb(138, 148, 144);
            lblValorQuantidade.FlatStyle = FlatStyle.Flat;
            lblValorQuantidade.Tag = "produto_dinamico";
            lblValorQuantidade.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblValorQuantidade);

            // Label de valor
            Label lblValor = new Label();
            lblValor.Text = "Valor:";
            lblValor.Location = new Point(557, posicaoY);
            lblValor.AutoSize = true;
            lblValor.ForeColor = Color.White;
            lblValor.Tag = "produto_dinamico";
            lblValor.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblValor);

            // Campo do valor do produto
            Label lblValorPreco = new Label();
            lblValorPreco.Text = "R$ " + preco.ToString("N2"); // Formata como moeda
            lblValorPreco.Location = new Point(610, posicaoY);
            lblValorPreco.Size = new Size(88, 25);
            lblValorPreco.ForeColor = Color.White;
            lblValorPreco.BackColor = Color.FromArgb(138, 148, 144);
            lblValorPreco.FlatStyle = FlatStyle.Flat;
            lblValorPreco.Tag = "produto_dinamico";
            lblValorPreco.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            pnDetalheslProdutos.Controls.Add(lblValorPreco);
        }

        //======================FUNÇÕES DE FILTRO======================
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            CarregarNotasFiscaisComFiltro();
        }

        private void CarregarNotasFiscaisComFiltro()
        {
            // Limpa as notas fiscais atuais
            LimparNotasFiscaisAnteriores();

            // Obtém o texto do filtro
            string filtro = txtFiltro.Text.Trim();

            // Constrói a query base
            string query = "SELECT ID_NOTA_VENDA, COD_NOTA_VENDA, CPF_CNPJ_VENDA FROM NOTA_FISCAL_VENDA";

            // Adiciona o filtro se houver texto
            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE COD_NOTA_VENDA LIKE @filtro OR CPF_CNPJ_VENDA LIKE @filtro";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Adiciona o parâmetro do filtro se necessário
                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                }

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                int posY = 130; // posição inicial no panel

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    MessageBox.Show(id.ToString());
                    string cod = dr.GetString(1);
                    string cpf = dr.GetString(2);

                    // Criar o GroupBox
                    GroupBox gb = new GroupBox();
                    gb.Width = pnNotasFiscais.Width - 5;
                    gb.Height = 55;
                    gb.Left = 0;
                    gb.Top = posY;
                    gb.BackColor = Color.FromArgb(58, 147, 116);

                    // Criar Label
                    Label lbl = new Label();
                    lbl.Text = $"{cod}";
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    lbl.AutoSize = true;
                    lbl.Left = 5;
                    lbl.Top = 20;

                    // Criar Botão
                    Button btn = new Button();
                    btn.Text = "Ver venda";
                    btn.Width = 83;
                    btn.Height = 27;
                    btn.Top = 16;
                    btn.Left = 200;
                    btn.BackColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += (sen, ev) => MostrarVenda(id);

                    // Adicionar itens ao GroupBox
                    gb.Controls.Add(lbl);
                    gb.Controls.Add(btn);

                    // Adicionar ao Panel
                    pnNotasFiscais.Controls.Add(gb);

                    // Atualizar posição vertical
                    posY += gb.Height + 15;
                }
            }
        }

        private void LimparNotasFiscaisAnteriores()
        {
            // Remove todos os GroupBoxes do panel
            var controlesParaRemover = new List<Control>();

            foreach (Control control in pnNotasFiscais.Controls)
            {
                if (control is GroupBox)
                {
                    controlesParaRemover.Add(control);
                }
            }

            foreach (Control control in controlesParaRemover)
            {
                pnNotasFiscais.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            // Limpa o texto do filtro
            txtFiltro.Text = "";

            // Recarrega todas as notas fiscais sem filtro
            CarregarNotasFiscaisComFiltro();
        }
    }
}







































































//Estoy loko 2.0