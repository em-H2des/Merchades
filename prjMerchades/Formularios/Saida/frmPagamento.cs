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
using System.Configuration;


namespace Merchades
{
    public partial class frmPagamento : Form
    {
        //cria variável privada pra pegar o valor e codigo
        private frmMenu _valorTotal;
        private string _codFiscal;
        private string _cpf;
        public DataGridViewRowCollection _infoProdutos;
        public frmPagamento(frmMenu valorTotal, string codFiscal, string cpf, DataGridViewRowCollection infoProdutos)
        {
            InitializeComponent();
            //Armazena o valor e código
            _valorTotal = valorTotal;
            _codFiscal = codFiscal;
            _cpf = cpf;
            _infoProdutos = infoProdutos;
        }
        private void btnCancelaVenda_Click(object sender, EventArgs e)
        {
            //chama o método do outro forms
            _valorTotal.LimparTelaVendas();
            frmMenuSaida novoForm = new frmMenuSaida();
            //frmMenu menuCarrinho = frmMenu();
            //menuCarrinho.Hide();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for aberto
        }

        private void btnCancelaOperacao_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o formPagamento e mostra a tela formVendas que está aberta atrás
        }

        private void btnConfirmaCompra_Click(object sender, EventArgs e)
        {
            //Pega os valores para chamar o método SalvarNotaFiscal

            //pega a string de conexão com o bd
            string stringDeConexao = prjMerchades.Properties.Settings.Default.ConnectionString;

            //Data emissao:
            System.DateTime dataEmissao = DateTime.Now.Date;

            //ValorVenda:
            string totalString = _valorTotal.ValorTotal.Replace("R$", "").Replace(" ", "");
            decimal valorVendaDecimal = 0;
            decimal.TryParse(totalString, out valorVendaDecimal);

            //codNotaVenda
            string codNotaVenda = _codFiscal.ToString();

            //Parcelas
            int qtdParcelas = (int)numEstoqueAddProduto.Value;

            //cpf
            string cpf = _cpf;

            //idPagamento
            int idPagamento = (cmbFormaPagamento.SelectedIndex) + 1;

            int idNotaVenda = SalvarNotaFiscal(stringDeConexao, dataEmissao, valorVendaDecimal, codNotaVenda, qtdParcelas, cpf, idPagamento);


            if (idNotaVenda > 0)
            {
                bool deuErro = false;
                foreach (DataGridViewRow linhaProduto in _infoProdutos)
                {
                    //qtdProduto
                    int qtdProduto = Convert.ToInt32(linhaProduto.Cells[1].Value);

                    //idProduto
                    int idProduto = Convert.ToInt32(linhaProduto.Cells[4].Value);

                    bool produto = SalvarItensNotaVenda(stringDeConexao, codNotaVenda, qtdProduto, idProduto, idNotaVenda);
                    if (!produto)
                    {
                        deuErro = true;
                    }
                }
                if (!deuErro)
                {
                    MessageBox.Show("Venda e Produtos cadastrados com sucesso!");
                }
                else
                {
                    MessageBox.Show("Algo explodiu os produtos");
                }
            }
            else {
                MessageBox.Show("Algo deu errado no cadastro da nota fiscal de venda");
            }

            frmMenu menuCarrinhoAberto = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();

            // 2. Se ele for encontrado, fecha ele
            if (menuCarrinhoAberto != null)
            {
                menuCarrinhoAberto.Close();
            }

            // 3. Fecha o formulário atual (frmPagamento)
            this.Close();
        }

        //Método para salvar a notaFiscal 
        public int SalvarNotaFiscal(string StringConexao, System.DateTime dataEmissao, decimal valorVenda, string codNotaVenda, int qtdParcelas, string cpf, int idPagamento)
        {

            string sqlInsert = @"
                INSERT INTO NOTA_FISCAL_VENDA (
                    DATA_EMISSAO,
                    VALOR_VENDA,
                    COD_NOTA_VENDA,
                    QTD_PARCELAS,
                    CPF_CNPJ_VENDA,
                    OBSERVACAO,
                    STATUS_VENDA,
                    ID_METODO_PAGAMENTO
                )
                VALUES (
                    @DataEmissao,
                    @ValorVenda,
                    @CodNota,
                    @QtdParcelas,
                    @CpfCnpj,
                    @Observacao,
                    @Status,
                    @IdMetodoPagamento
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT)
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(StringConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {

                        cmd.Parameters.AddWithValue("@DataEmissao", dataEmissao);
                        cmd.Parameters.AddWithValue("ValorVenda", valorVenda);
                        cmd.Parameters.AddWithValue("@CodNota", codNotaVenda);
                        cmd.Parameters.AddWithValue("@QtdParcelas", qtdParcelas);
                        cmd.Parameters.AddWithValue("@CpfCnpj", cpf);
                        cmd.Parameters.AddWithValue("@Observacao", "Venda de Arroz");
                        cmd.Parameters.AddWithValue("@Status", "F");
                        cmd.Parameters.AddWithValue("@IdMetodoPagamento", idPagamento);
                        conn.Open();
                        int novoIdGerado = Convert.ToInt32(cmd.ExecuteScalar());
                        return novoIdGerado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar nota: " + ex.Message);
                return 0;
            }
        }

        public bool SalvarItensNotaVenda(string stringDeConexao, string codNotaVenda, int qtdProduto, int idProduto, int idNotaVenda)
        {
            string sqlInsert = @"
                INSERT INTO ITENS_NOTA_VENDA (
                    QTD_PRODUTO,
                    ID_PRODUTOS,
                    ID_NOTA_VENDA
                )
                VALUES (
                    @qtdProduto,
                    @idProduto,
                    @idNotaVenda
                );
            ";
            try
            {
                using (SqlConnection conn = new SqlConnection(stringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {

                        cmd.Parameters.AddWithValue("@qtdProduto", qtdProduto);
                        cmd.Parameters.AddWithValue("@idProduto", idProduto);
                        cmd.Parameters.AddWithValue("@idNotaVenda", idNotaVenda);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar nota: " + ex.Message);
                return false;
            }
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsDadosSaida.METODO_PAGAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.mETODO_PAGAMENTOTableAdapter.Fill(this.dsDadosSaida.METODO_PAGAMENTO);
            //Variável de Valor total
            lblValorTotal.Text = $"{_valorTotal.ValorTotal}";
        }
       

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se o pagamento for em cartão de crédito, surgem as parcelas
            if (cmbFormaPagamento.Text == "Cartão de Crédito")
            {
                lblParcelas.Visible = true;
                numEstoqueAddProduto.Visible = true;
            }
            else
            {
                lblParcelas.Visible = false;
                numEstoqueAddProduto.Visible = false;
            }

            //Se o pagamento for em dinheiro, text box para o valor pago
            if(cmbFormaPagamento.Text == "Dinheiro")
            {
                lblvalorPago.Visible = true;
                txtValorPago.Visible = true;
            }
            else
            {
                lblvalorPago.Visible = false;
                txtValorPago.Visible = false;
            }

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            //Cálculo do Troco: Transforma os dois em decimal e arrendonda para duas casas decimais
            //Pega o total, limpando os textos
            string totalString = _valorTotal.ValorTotal.Replace("R$", "").Replace(" ", "");

            decimal valorTotal = 0;
            decimal.TryParse(totalString, out valorTotal);

            //Pega o valor pago e converte-o em decimal
            string valorPagoString = txtValorPago.Text.Replace("R$", "").Replace(" ", "");
            decimal valorPago = 0;
            decimal.TryParse(valorPagoString, out valorPago);

            //calcula o troco
            decimal troco = valorPago - valorTotal;

            //verifica se houve troco ou não
            if (troco > 0)
            {
                lblTrocoVenda.Text = troco.ToString("C2");
            }
            else
            {
                lblTrocoVenda.Text = "R$ 0,00";
            }
        }
    }
}
