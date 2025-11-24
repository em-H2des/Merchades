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

namespace prjMerchades.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasOK()
        {
            if (TextBox_NomeUsuario.Text == "")
            {
                errorProvider.SetError(TextBox_NomeUsuario, "Informe o nome do usuário");
                return false;
            }
            else
                errorProvider.SetError(TextBox_NomeUsuario, "");

            if (TextBox_Senha.Text == "")
            {
                errorProvider.SetError(TextBox_Senha, "Informe a senha");
                return false;
            }
            else
                errorProvider.SetError(TextBox_Senha, "");

            return true;
        }    

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Deseja realmente fechar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (TextBox_Senha.UseSystemPasswordChar)
            {
                TextBox_Senha.UseSystemPasswordChar = false;
                Btn_Mostrar.Font = new Font("Segoe MDL2 Assets", 14);
                Btn_Mostrar.Text = "\xf78a"; // Olho aberto
            }
            else
            {
                TextBox_Senha.UseSystemPasswordChar = true;
                Btn_Mostrar.Font = new Font("Segoe MDL2 Assets", 14);
                Btn_Mostrar.Text = "\xE7B3"; // Olho riscado
            }
        }

        string connectionString = prjMerchades.Properties.Settings.Default.ConnectionString;

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                string usuario = TextBox_NomeUsuario.Text.Trim().ToLower();
                string senha = TextBox_Senha.Text;

                // Buscar usuário no banco de dados
                Usuario usuarioEncontrado = BuscarUsuario(usuario, senha);

                if (usuarioEncontrado != null)
                {
                    prjMerchades.Properties.Settings.Default.usuarioNome = usuarioEncontrado.NomeCadastrado;
                    prjMerchades.Properties.Settings.Default.usuarioNivel = usuarioEncontrado.Nivel.ToString();
                    // Redirecionar baseado no nível do usuário
                    switch (usuarioEncontrado.Nivel)
                    {
                        case 1: // Nível 1 - Entrada
                            MDIEntrada frmEntrada = new MDIEntrada();
                            frmEntrada.Show();
                            this.Hide();
                            break;

                        case 2: // Nível 2 - Saída
                            frmMenuSaida frmMenuSaida = new frmMenuSaida();
                            frmMenuSaida.Show();
                            this.Hide();
                            break;

                        case 3: // Nível 3 - Financeiro
                            MDIFinanceiro frmFinanceiro = new MDIFinanceiro();
                            frmFinanceiro.Show();
                            this.Hide();
                            break;

                        default:
                            MessageBox.Show("Nível de usuário não configurado!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    vErros++;

                    if (vErros == 3)
                    {
                        MessageBox.Show("Número de tentativas esgotado...");
                        Application.Exit();
                    }
                }
            }
        }

        // Método para buscar usuário no banco
        private Usuario BuscarUsuario(string usuario, string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT ID_USUARIO, NOME_CADASTRADO, USUARIO, SENHA_USUARIO, NIVEL_USUARIO 
                           FROM LOGIN_USUARIO 
                           WHERE USUARIO = @Usuario AND SENHA_USUARIO = @Senha";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Senha", senha);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    Id = reader.GetInt32(0),
                                    NomeCadastrado = reader.GetString(1),
                                    UsuarioLogin = reader.GetString(2),
                                    Senha = reader.GetString(3),
                                    Nivel = reader.GetInt32(4)
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}");
                }
            }

            return null;
        }

        // Classe para representar o usuário
        public class Usuario
        {
            public int Id { get; set; }
            public string NomeCadastrado { get; set; }
            public string UsuarioLogin { get; set; }
            public string Senha { get; set; }
            public int Nivel { get; set; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Btn_Mostrar.Text = "\xE7B3";
        }
    }
}
