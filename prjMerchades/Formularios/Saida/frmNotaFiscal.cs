using prjMerchades.Formularios;
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

        private void frmNotaFiscal_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT ID_NOTA_VENDA, COD_NOTA_VENDA FROM NOTA_FISCAL_VENDA";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                int posY = 35; // posição inicial no panel

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string cod = dr.GetString(1);

                    // Criar o GroupBox
                    GroupBox gb = new GroupBox();
                    gb.Width = panel2.Width - 60;
                    gb.Height = 55;
                    gb.Left = 22;
                    gb.Top = posY;
                    gb.BackColor = Color.FromArgb(58, 147, 116);

                    // Criar Label
                    Label lbl = new Label();
                    lbl.Text = $"{cod} - Venda {id}";
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    lbl.AutoSize = true;
                    lbl.Left = 5;
                    lbl.Top = 20;

                    // Criar Botão
                    Button btn = new Button();
                    btn.Text = "Ver venda";
                    btn.Width = 83;
                    btn.Height = 27;
                    btn.Top = 16;
                    btn.Left = 147;
                    btn.BackColor = Color.White;
                    btn.Click += (sen, ev) => MostrarCompra(id);

                    // Adicionar itens ao GroupBox
                    gb.Controls.Add(lbl);
                    gb.Controls.Add(btn);

                    // Adicionar ao Panel
                    panel2.Controls.Add(gb);

                    // Atualizar posição vertical
                    posY += gb.Height + 15;
                }
            }
        }

        private void MostrarCompra(int id)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT N.COD_NOTA_VENDA, N.DATA_EMISSAO, N.QTD_PARCELAS, C.NOME_CLIENTE FROM NOTA_FISCAL_VENDA N INNER JOIN CLIENTE C ON C.ID_CLIENTE = N.ID_CLIENTE WHERE N.ID_NOTA_VENDA = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    label103.Text = $"Venda {id}";
                    
                    string codNota = dr.GetString(0);
                    DateTime emissao = dr.GetDateTime(1);
                    int parcelas = dr.GetInt32(2);
                    string cliente = dr.GetString(3);

                    lblCodigoNF.Text = codNota.ToString();
                    lblDataEmissaoNF.Text = emissao.ToString();
                    lblParcelasNF.Text = parcelas.ToString();
                    lblClienteNF.Text = cliente.ToString();

                }
            }
        }

    }
}
