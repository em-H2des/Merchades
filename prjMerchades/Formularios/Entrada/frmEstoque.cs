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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada.ESTOQUEEntradaNomes'. Você pode movê-la ou removê-la conforme necessário.
            this.eSTOQUEEntradaNomesTableAdapter.Fill(this.daDadosEntrada.ESTOQUEEntradaNomes);

            this.RprtVw_Estoque.RefreshReport();
            this.RprtVw_Estoque.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras();
            frmCompras.MdiParent = this.MdiParent ;
            frmCompras.Show();
        }
    }
}
