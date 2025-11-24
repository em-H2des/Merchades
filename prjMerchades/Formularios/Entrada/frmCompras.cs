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
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada3.comprasAntigas'. Você pode movê-la ou removê-la conforme necessário.
            this.comprasAntigasTableAdapter.Fill(this.daDadosEntrada.comprasAntigas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada2.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.nOTA_FISCAL_FORNECEDORTableAdapter.Fill(this.daDadosEntrada.NOTA_FISCAL_FORNECEDOR);
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Data2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //colocando o table adapter de "Fornecedor" em uma variavel e preenchendo a tabela com os dados
            var fornecedorTA = new Dados.daDadosEntradaTableAdapters.FORNECEDORTableAdapter(); 
            fornecedorTA.Fill(daDadosEntrada.FORNECEDOR);

            int codigoFornecedor =  int.Parse(txtCodFornecedor.Text);

            //verificando se o fornecedor digitado ja existe no banco, se nao existe abre tela de cadastro
            var fornecedor = daDadosEntrada.FORNECEDOR.FindByID_FORNECEDOR(codigoFornecedor);
        
            if (fornecedor == null)
            {
                MessageBox.Show("O fornecedor informado nao existe, cadastre-o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var formCadastroFornecedor = new frmCadFornecedor();
                formCadastroFornecedor.MdiParent = this.MdiParent;
                formCadastroFornecedor.Show();

                return; //intemrrompe a execução
            }

            //table adapters
            var notaFiscalFornecedor = new Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter();
            var produtos = new Dados.daDadosEntradaTableAdapters.PRODUTOSEntradaTableAdapter();
            var estoque = new Dados.daDadosEntradaTableAdapters.ESTOQUEEntradaTableAdapter();


            //insert na tabela de nota fiscal
            notaFiscalFornecedor.Insert(
                dateEmissao.Value,
                int.Parse(txtVlrTtl.Text),
                txtCodNF.Text,
                txtTipoProduto.Text,
                codigoFornecedor,
                "n"
             );

            //insert na tabela produto
            produtos.Insert(
                txtNomeProduto.Text,
                txtTipoProduto.Text,
                cmbTipoUnitario.Text,
                decimal.Parse(txtPreco.Text),
                int.Parse(txtCodBarras.Text)
             );

            //recuperando os IDs para dar insert na tabela "Estoque"
            int idProduto = int.Parse(produtos.ultimoId().ToString());
            int idNF = int.Parse(notaFiscalFornecedor.ultimoId().ToString());
            int qtd = (int)numQtd.Value;

            //insert na tabela estoque
            estoque.Insert(
                qtd,
                idProduto,
                idNF
             );

            MessageBox.Show("Entrada cadastrada com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

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


    }
}
