using Merchades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios
{
    public partial class frmMenuSaida : Form
    {
        public frmMenuSaida()
        {
            InitializeComponent();
        }

        private void btnVercompra_Click(object sender, EventArgs e)
        {
            frmNotaFiscal novoForm = new frmNotaFiscal();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {

            // Verifica se já existe um formMenu aberto
            frmMenu menuAberto = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();

            if (menuAberto == null)
            {
                // Cria e mostra o formMenu se não estiver aberto
                menuAberto = new frmMenu();
                menuAberto.Show();
            }
            else
            {
                // Se já estiver aberto, apenas traz para frente
                menuAberto.Show();
                menuAberto.BringToFront();
            }
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            prjMerchades.Properties.Settings.Default.usuarioNome = "";
            prjMerchades.Properties.Settings.Default.usuarioNivel = "";
            Login telaLogin = new Login();
            telaLogin.Show();
            this.Hide();
        }

        private void frmMenuSaida_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text += prjMerchades.Properties.Settings.Default.usuarioNome;
        }
    }
    
}
