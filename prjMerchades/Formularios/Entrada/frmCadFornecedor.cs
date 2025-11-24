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
    public partial class frmCadFornecedor : Form
    {
        public frmCadFornecedor()
        {
            InitializeComponent();
            comboBox_Estado.Items.AddRange(new string[]
        {
            // Se preferirem só mudar para os itens do Estados
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
                "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
                "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ====== 1. VERIFICA SE TODOS OS CAMPOS ESTÃO PREENCHIDOS ======
            if (string.IsNullOrWhiteSpace(txtBox_Fornecedor.Text) ||
                string.IsNullOrWhiteSpace(maskedCNPJ.Text) || 
                string.IsNullOrWhiteSpace(maskedTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtBox_Email.Text) || 
                comboBox_Estado.SelectedIndex == -1 || 
                string.IsNullOrWhiteSpace(maskedCEP.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // ====== 2. CHECA EMAIL ======
            if (!EmailValido(txtBox_Email.Text))
            {
                MessageBox.Show("Digite um e-mail válido (exemplo: nome@gmail.com).",
                                "E-mail inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // ====== 3. STRING DE CONEXÃO ======
            string conexao = @"Server=localhost;Database=merchades;Trusted_Connection=True;";

            // ====== 4. QUERY ======
            string query = @"INSERT INTO FORNECEDOR 
                        (NOME_FORNECEDOR, TELEFONE_FORNECEDOR, EMAIL_FORNECEDOR, 
                         ESTADO_FORNECEDOR, CEP_FORNECEDOR, CNPJ_FORNECEDOR)
                     VALUES 
                        (@NOME, @TELEFONE, @EMAIL, @ESTADO, @CEP, @CNPJ)";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // ====== PASSA OS PARÂMETROS ======
                    cmd.Parameters.AddWithValue("@NOME", txtBox_Fornecedor.Text);
                    cmd.Parameters.AddWithValue("@TELEFONE", maskedTelefone.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txtBox_Email.Text);
                    cmd.Parameters.AddWithValue("@ESTADO", comboBox_Estado.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CEP", maskedCEP.Text);
                    cmd.Parameters.AddWithValue("@CNPJ", maskedCNPJ.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro Finalizado com Sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // ====== LIMPA ======
                txtBox_Fornecedor.Clear();
                maskedCNPJ.Clear();
                maskedTelefone.Clear();
                txtBox_Email.Clear();
                comboBox_Estado.SelectedIndex = -1;
                maskedCEP.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}