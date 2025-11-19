namespace prjMerchades.Formularios.Entrada
{
    partial class frmListagemFornecedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemFornecedor));
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosEntrada = new prjMerchades.Dados.dsDadosEntrada();
            this.ReportViewerFornec = new Microsoft.Reporting.WinForms.ReportViewer();
            this.picBox_Header = new System.Windows.Forms.PictureBox();
            this.lbl_FiltrarPor = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.cmbColunas = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblColunas = new System.Windows.Forms.Label();
            this.fORNECEDORTableAdapter = new prjMerchades.Dados.dsDadosEntradaTableAdapters.FORNECEDORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.dsDadosEntrada;
            // 
            // dsDadosEntrada
            // 
            this.dsDadosEntrada.DataSetName = "dsDadosEntrada";
            this.dsDadosEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewerFornec
            // 
            this.ReportViewerFornec.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DadosFornec";
            reportDataSource1.Value = this.fORNECEDORBindingSource;
            this.ReportViewerFornec.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerFornec.LocalReport.ReportEmbeddedResource = "prjMerchades.Relatorios.RelatorioFornecedores.rdlc";
            this.ReportViewerFornec.Location = new System.Drawing.Point(0, 278);
            this.ReportViewerFornec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportViewerFornec.Name = "ReportViewerFornec";
            this.ReportViewerFornec.ServerReport.BearerToken = null;
            this.ReportViewerFornec.Size = new System.Drawing.Size(1546, 472);
            this.ReportViewerFornec.TabIndex = 0;
            // 
            // picBox_Header
            // 
            this.picBox_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.picBox_Header.Location = new System.Drawing.Point(0, -4);
            this.picBox_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Header.Name = "picBox_Header";
            this.picBox_Header.Size = new System.Drawing.Size(1632, 171);
            this.picBox_Header.TabIndex = 5;
            this.picBox_Header.TabStop = false;
            // 
            // lbl_FiltrarPor
            // 
            this.lbl_FiltrarPor.AutoSize = true;
            this.lbl_FiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_FiltrarPor.Location = new System.Drawing.Point(536, 210);
            this.lbl_FiltrarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FiltrarPor.Name = "lbl_FiltrarPor";
            this.lbl_FiltrarPor.Size = new System.Drawing.Size(153, 31);
            this.lbl_FiltrarPor.TabIndex = 15;
            this.lbl_FiltrarPor.Text = "Filtrar Por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtFiltro.Location = new System.Drawing.Point(995, 207);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(349, 38);
            this.txtFiltro.TabIndex = 17;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DisplayMember = "TELEFONE_FORNECEDOR";
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Igual a",
            "Que começa com",
            "Que contém",
            "Que termina com"});
            this.cmbFiltro.Location = new System.Drawing.Point(699, 208);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(288, 37);
            this.cmbFiltro.TabIndex = 18;
            this.cmbFiltro.ValueMember = "TELEFONE_FORNECEDOR";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_titulo.Location = new System.Drawing.Point(46, 43);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(762, 69);
            this.lbl_titulo.TabIndex = 41;
            this.lbl_titulo.Text = "Listagem de Fornecedores";
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(1362, 32);
            this.picBox_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(133, 107);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 42;
            this.picBox_Logo.TabStop = false;
            // 
            // cmbColunas
            // 
            this.cmbColunas.DisplayMember = "COLUMN_NAME";
            this.cmbColunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbColunas.FormattingEnabled = true;
            this.cmbColunas.Items.AddRange(new object[] {
            "NOME_FORNECEDOR",
            "ESTADO_FORNECEDOR"});
            this.cmbColunas.Location = new System.Drawing.Point(159, 209);
            this.cmbColunas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColunas.Name = "cmbColunas";
            this.cmbColunas.Size = new System.Drawing.Size(370, 37);
            this.cmbColunas.TabIndex = 43;
            this.cmbColunas.ValueMember = "COLUMN_NAME";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(1352, 203);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(163, 38);
            this.btnFiltrar.TabIndex = 44;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblColunas.Location = new System.Drawing.Point(12, 210);
            this.lblColunas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(130, 31);
            this.lblColunas.TabIndex = 45;
            this.lblColunas.Text = "Colunas:";
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // frmListagemFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1546, 750);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbColunas);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbl_FiltrarPor);
            this.Controls.Add(this.picBox_Header);
            this.Controls.Add(this.ReportViewerFornec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListagemFornecedor";
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.frmListagemFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFornec;
        private System.Windows.Forms.PictureBox picBox_Header;
        private System.Windows.Forms.Label lbl_FiltrarPor;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.ComboBox cmbColunas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblColunas;
        private Dados.dsDadosEntrada dsDadosEntrada;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private Dados.dsDadosEntradaTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
    }
}