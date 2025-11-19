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
    }
}
