using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Entrada
{
    public partial class frmListagemFornecedor : Form
    {
        public frmListagemFornecedor()
        {
            InitializeComponent();

            picBox_Header.SendToBack();
        }

        private void frmListagemFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsDadosEntrada.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.dsDadosEntrada.FORNECEDOR);
            this.ReportViewerFornec.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vTexto, vFiltro = "";

            vColuna = cmbColunas.Text;
            vProcurar = cmbFiltro.Text;
            vTexto = txtFiltro.Text.Trim().Replace("'", "''");

            vFiltro = vColuna;

            if (vProcurar == "Que começa com")
            {
                vFiltro += " like '" + vTexto + "%'";
            }

            else if (vProcurar == "Que contém")
            {
                vFiltro += " like '%" + vTexto + "%'";
            }

            else if (vProcurar == "Que termina com")
            {
                vFiltro += " like '%" + vTexto + "'";
            }

            else if (vProcurar == "Igual a")
            {
                vFiltro += " = '" + vTexto + "'";
            }

            else
            {
                vFiltro = "";
            }
            this.fORNECEDORBindingSource.Filter = vFiltro;
            this.ReportViewerFornec.RefreshReport();
        }
    }
}
