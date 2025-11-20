using prjMerchades.Dados.dsDadosFinanceiroTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Financeiro
{
    public partial class frmParcelasVenda : Form
    {
        public frmParcelasVenda()
        {
            InitializeComponent();
        }
        private void btnLimparFiltroParcelas_Click(object sender, EventArgs e)
        {
            this.dEBITOPARCELASBindingSource.Filter = $"ID_PARCELAS = {dgvTabelaParcelas.SelectedRows[0].Cells[0].Value.ToString()}";
        }

        private void btnAplicarFiltroParcelas_Click(object sender, EventArgs e)
        {
            string filtrarPor = cmbFiltroParcelas.Text;
            string buscarParcela = txtBuscarParcela.Text;

            this.dEBITOPARCELASBindingSource.Filter = $"Convert({filtrarPor}, 'System.String') LIKE '%{buscarParcela}%'";
        }
        private void txtBuscarParcelas_TextChanged(object sender, EventArgs e)
        {
            string textoDeFiltro = txtBuscarParcelas.Text;
            this.vwPARCELASCPFBindingSource.Filter = $"CPF_CNPJ_CLIENTE LIKE '%{textoDeFiltro}%'";
            if (textoDeFiltro == "")
            {
                this.vwPARCELASCPFBindingSource.Filter = "";
            }
        }

        private void frmParcelasVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDadosFinanceiro.Vw_PARCELAS_CPF' table. You can move, or remove it, as needed.
            this.vw_PARCELAS_CPFTableAdapter.Fill(this.dsDadosFinanceiro.Vw_PARCELAS_CPF);

        }

        bool carregouDebitoParcelas = false;
        private void dgvTabelaParcelas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTabelaParcelas.SelectedRows.Count > 0)
            {
                if (!carregouDebitoParcelas)
                {
                    // TODO: This line of code loads data into the 'dsDadosFinanceiro.DEBITO_PARCELAS' table. You can move, or remove it, as needed.
                    this.dEBITO_PARCELASTableAdapter.Fill(this.dsDadosFinanceiro.DEBITO_PARCELAS);
                    carregouDebitoParcelas = true;
                }
                int idParcela = Convert.ToInt32(dgvTabelaParcelas.SelectedRows[0].Cells[0].Value);
                this.dEBITOPARCELASBindingSource.Filter = $"ID_PARCELAS = {idParcela}";
            }
        }

        private void btnPagarParcelaVenda_Click(object sender, EventArgs e)
        {
            var adapterDebitoParcelas = new DEBITO_PARCELASTableAdapter();
            var adapterParcelas = new Vw_PARCELAS_CPFTableAdapter();

            for (int i = 0; i < dgvDebitoParcelas.SelectedRows.Count; i++)
            {
                int idDebitoParcela = Convert.ToInt32(dgvDebitoParcelas.SelectedRows[i].Cells[7].Value);
                string numParcelas = dgvDebitoParcelas.SelectedRows[i].Cells[1].Value.ToString();
                string observacao = dgvDebitoParcelas.SelectedRows[i].Cells[6].Value.ToString();
                
                //PAGA A PARCELA
                adapterDebitoParcelas.PR_PagarParcelas(idDebitoParcela, numParcelas, observacao);
            }

            //Atualiza as datagrids
            adapterDebitoParcelas.Fill(this.dsDadosFinanceiro.DEBITO_PARCELAS);
            this.dEBITOPARCELASBindingSource.ResetBindings(false);
            
            adapterParcelas.Fill(this.dsDadosFinanceiro.Vw_PARCELAS_CPF);
            this.vwPARCELASCPFBindingSource.ResetBindings(false);

        }
    }
}
