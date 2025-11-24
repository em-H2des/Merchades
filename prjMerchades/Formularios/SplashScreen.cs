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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10); // aumenta 1 por tick
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                // Exemplo: abrir o form principal e fechar o splash
                Login frmLogin = new Login();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
           
                progressBar1.Value = 0;
                timer1.Start();

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.FromArgb(113, 119, 68);


        }
    }
}
