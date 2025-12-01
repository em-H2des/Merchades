using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMerchades.Formularios.Entrada;


namespace prjMerchades.Formularios
{
    public partial class MDIEntrada : Form
    {
        private int childFormNumber = 0;

        public MDIEntrada()
        {
            InitializeComponent();
        }

        private void listagemDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemFornecedor frmListagemFornecedor = new frmListagemFornecedor();
            frmListagemFornecedor.MdiParent = this;
            frmListagemFornecedor.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.MdiParent = this;
            frmEstoque.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras();
            frmCompras.MdiParent = this;
            frmCompras.Show();
        }

        private void exibirNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibirNotaFiscal frmExibirNotaFiscal = new frmExibirNotaFiscal();
            frmExibirNotaFiscal.MdiParent = this;
            frmExibirNotaFiscal.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Deseja realmente deslogar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                prjMerchades.Properties.Settings.Default.usuarioNome = "";
                prjMerchades.Properties.Settings.Default.usuarioNivel = "";
                Login telaLogin = new Login();
                telaLogin.Show();
                this.Hide();
            }
        }

        private void MDIEntrada_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text += prjMerchades.Properties.Settings.Default.usuarioNome;
        }

        private void cadastroFrncdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frmCadastroFornecedor = new frmCadFornecedor();
            frmCadastroFornecedor.MdiParent = this;
            frmCadastroFornecedor.Show();
        }
        private void MDIEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor telaCadFornecedor = new frmCadFornecedor();
            telaCadFornecedor.MdiParent = this;
            telaCadFornecedor.Show();
        }
    }
}