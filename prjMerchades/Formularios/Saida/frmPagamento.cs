using prjMerchades.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchades
{
    public partial class frmPagamento : Form
    {
        //cria variável privada pra pegar o valor e codigo
        private frmMenu _valorTotal;
        private int _codFiscal;
        private string _cpf;
        public frmPagamento(frmMenu valorTotal, int codFiscal, string cpf)
        {
            InitializeComponent();
            //Armazena o valor e código
            _valorTotal = valorTotal;
            _codFiscal = codFiscal;
            _cpf = cpf;
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
            string totalString = _valorTotal.ValorTotal.Replace("R$", "").Replace(" ", "");

            // Converta para decimal
            decimal valorVendaDecimal = 0;
            decimal.TryParse(totalString, out valorVendaDecimal);

            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for aberto
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsDadosSaida.METODO_PAGAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.mETODO_PAGAMENTOTableAdapter.Fill(this.dsDadosSaida.METODO_PAGAMENTO);
            //Variável de Valor total
            lblValorTotal.Text = $"R$ {_valorTotal.ValorTotal}";
        }
       

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se o pagamento for em cartão de crédito, surgem as parcelas
            if (cmbFormaPagamento.Text == "Cartão de Crédito")
            {
                lblParcelas.Visible = true;
                numEstoqueAddProduto.Visible = true;
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
