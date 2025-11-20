namespace prjMerchades.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.TextBox_Senha = new System.Windows.Forms.TextBox();
            this.TextBox_NomeUsuario = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Merchades_picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merchades_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome de usuário:";
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Mostrar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F);
            this.Btn_Mostrar.Location = new System.Drawing.Point(341, 349);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(30, 31);
            this.Btn_Mostrar.TabIndex = 13;
            this.Btn_Mostrar.UseVisualStyleBackColor = false;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Cancelar.Location = new System.Drawing.Point(271, 410);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Cancelar.TabIndex = 12;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.Green;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_OK.Location = new System.Drawing.Point(95, 410);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(100, 31);
            this.Btn_OK.TabIndex = 11;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // TextBox_Senha
            // 
            this.TextBox_Senha.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Senha.Location = new System.Drawing.Point(95, 349);
            this.TextBox_Senha.Name = "TextBox_Senha";
            this.TextBox_Senha.Size = new System.Drawing.Size(237, 32);
            this.TextBox_Senha.TabIndex = 10;
            this.TextBox_Senha.UseSystemPasswordChar = true;
            // 
            // TextBox_NomeUsuario
            // 
            this.TextBox_NomeUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NomeUsuario.Location = new System.Drawing.Point(95, 269);
            this.TextBox_NomeUsuario.Name = "TextBox_NomeUsuario";
            this.TextBox_NomeUsuario.Size = new System.Drawing.Size(276, 32);
            this.TextBox_NomeUsuario.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Merchades_picBox
            // 
            this.Merchades_picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Merchades_picBox.BackgroundImage")));
            this.Merchades_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Merchades_picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Merchades_picBox.InitialImage")));
            this.Merchades_picBox.Location = new System.Drawing.Point(95, 27);
            this.Merchades_picBox.Name = "Merchades_picBox";
            this.Merchades_picBox.Size = new System.Drawing.Size(276, 199);
            this.Merchades_picBox.TabIndex = 16;
            this.Merchades_picBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(468, 469);
            this.ControlBox = false;
            this.Controls.Add(this.Merchades_picBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.TextBox_Senha);
            this.Controls.Add(this.TextBox_NomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merchades_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TextBox TextBox_Senha;
        private System.Windows.Forms.TextBox TextBox_NomeUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox Merchades_picBox;
    }
}