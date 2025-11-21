namespace prjMerchades.Formularios.Financeiro
{
    partial class frmParcelasVenda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarParcela = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTabelaParcelas = new System.Windows.Forms.DataGridView();
            this.iDPARCELASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDPARCELASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSGERALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPARCELASCPFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosFinanceiro = new prjMerchades.Dados.dsDadosFinanceiro();
            this.dgvDebitoParcelas = new System.Windows.Forms.DataGridView();
            this.iDDEBITOPARCELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMPARCELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPARCELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPAGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPARCELASDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEBITOPARCELASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPagarParcelaVenda = new System.Windows.Forms.Button();
            this.btnLimparFiltroParcelas = new System.Windows.Forms.Button();
            this.txtBuscarParcelas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarFiltroParcelas = new System.Windows.Forms.Button();
            this.cmbFiltroParcelas = new System.Windows.Forms.ComboBox();
            this.dsDadosSaida = new prjMerchades.Dados.dsDadosSaida();
            this.dEBITO_PARCELASTableAdapter = new prjMerchades.Dados.dsDadosFinanceiroTableAdapters.DEBITO_PARCELASTableAdapter();
            this.vw_PARCELAS_CPFTableAdapter = new prjMerchades.Dados.dsDadosFinanceiroTableAdapters.Vw_PARCELAS_CPFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPARCELASCPFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitoParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEBITOPARCELASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades1;
            this.pictureBox1.Location = new System.Drawing.Point(644, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtBuscarParcela);
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.btnPagarParcelaVenda);
            this.groupBox1.Controls.Add(this.btnLimparFiltroParcelas);
            this.groupBox1.Controls.Add(this.txtBuscarParcelas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAplicarFiltroParcelas);
            this.groupBox1.Controls.Add(this.cmbFiltroParcelas);
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(886, 492);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscarParcela
            // 
            this.txtBuscarParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.txtBuscarParcela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.txtBuscarParcela.ForeColor = System.Drawing.Color.White;
            this.txtBuscarParcela.Location = new System.Drawing.Point(586, 55);
            this.txtBuscarParcela.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscarParcela.Name = "txtBuscarParcela";
            this.txtBuscarParcela.Size = new System.Drawing.Size(274, 29);
            this.txtBuscarParcela.TabIndex = 58;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 134);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTabelaParcelas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDebitoParcelas);
            this.splitContainer1.Size = new System.Drawing.Size(886, 297);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 57;
            // 
            // dgvTabelaParcelas
            // 
            this.dgvTabelaParcelas.AllowUserToAddRows = false;
            this.dgvTabelaParcelas.AllowUserToDeleteRows = false;
            this.dgvTabelaParcelas.AutoGenerateColumns = false;
            this.dgvTabelaParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTabelaParcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTabelaParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPARCELASDataGridViewTextBoxColumn,
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn,
            this.vALORTOTALDataGridViewTextBoxColumn,
            this.qTDPARCELASDataGridViewTextBoxColumn,
            this.sTATUSGERALDataGridViewTextBoxColumn});
            this.dgvTabelaParcelas.DataSource = this.vwPARCELASCPFBindingSource;
            this.dgvTabelaParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabelaParcelas.Location = new System.Drawing.Point(0, 0);
            this.dgvTabelaParcelas.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.dgvTabelaParcelas.MultiSelect = false;
            this.dgvTabelaParcelas.Name = "dgvTabelaParcelas";
            this.dgvTabelaParcelas.ReadOnly = true;
            this.dgvTabelaParcelas.RowHeadersWidth = 51;
            this.dgvTabelaParcelas.RowTemplate.Height = 24;
            this.dgvTabelaParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelaParcelas.Size = new System.Drawing.Size(347, 297);
            this.dgvTabelaParcelas.TabIndex = 53;
            this.dgvTabelaParcelas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelaParcelas_RowEnter);
            // 
            // iDPARCELASDataGridViewTextBoxColumn
            // 
            this.iDPARCELASDataGridViewTextBoxColumn.DataPropertyName = "ID_PARCELAS";
            this.iDPARCELASDataGridViewTextBoxColumn.HeaderText = "ID_PARCELAS";
            this.iDPARCELASDataGridViewTextBoxColumn.Name = "iDPARCELASDataGridViewTextBoxColumn";
            this.iDPARCELASDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPARCELASDataGridViewTextBoxColumn.Width = 105;
            // 
            // cPFCNPJCLIENTEDataGridViewTextBoxColumn
            // 
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CPF_CNPJ_CLIENTE";
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn.HeaderText = "CPF_CNPJ_CLIENTE";
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn.Name = "cPFCNPJCLIENTEDataGridViewTextBoxColumn";
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFCNPJCLIENTEDataGridViewTextBoxColumn.Width = 136;
            // 
            // vALORTOTALDataGridViewTextBoxColumn
            // 
            this.vALORTOTALDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL";
            this.vALORTOTALDataGridViewTextBoxColumn.HeaderText = "VALOR_TOTAL";
            this.vALORTOTALDataGridViewTextBoxColumn.Name = "vALORTOTALDataGridViewTextBoxColumn";
            this.vALORTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALDataGridViewTextBoxColumn.Width = 109;
            // 
            // qTDPARCELASDataGridViewTextBoxColumn
            // 
            this.qTDPARCELASDataGridViewTextBoxColumn.DataPropertyName = "QTD_PARCELAS";
            this.qTDPARCELASDataGridViewTextBoxColumn.HeaderText = "QTD_PARCELAS";
            this.qTDPARCELASDataGridViewTextBoxColumn.Name = "qTDPARCELASDataGridViewTextBoxColumn";
            this.qTDPARCELASDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDPARCELASDataGridViewTextBoxColumn.Width = 117;
            // 
            // sTATUSGERALDataGridViewTextBoxColumn
            // 
            this.sTATUSGERALDataGridViewTextBoxColumn.DataPropertyName = "STATUS_GERAL";
            this.sTATUSGERALDataGridViewTextBoxColumn.HeaderText = "STATUS_GERAL";
            this.sTATUSGERALDataGridViewTextBoxColumn.Name = "sTATUSGERALDataGridViewTextBoxColumn";
            this.sTATUSGERALDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSGERALDataGridViewTextBoxColumn.Width = 117;
            // 
            // vwPARCELASCPFBindingSource
            // 
            this.vwPARCELASCPFBindingSource.DataMember = "Vw_PARCELAS_CPF";
            this.vwPARCELASCPFBindingSource.DataSource = this.dsDadosFinanceiro;
            // 
            // dsDadosFinanceiro
            // 
            this.dsDadosFinanceiro.DataSetName = "dsDadosFinanceiro";
            this.dsDadosFinanceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDebitoParcelas
            // 
            this.dgvDebitoParcelas.AllowUserToAddRows = false;
            this.dgvDebitoParcelas.AllowUserToDeleteRows = false;
            this.dgvDebitoParcelas.AutoGenerateColumns = false;
            this.dgvDebitoParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDebitoParcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDebitoParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitoParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDEBITOPARCELADataGridViewTextBoxColumn,
            this.nUMPARCELADataGridViewTextBoxColumn,
            this.vALORPARCELADataGridViewTextBoxColumn,
            this.dATAVENCIMENTODataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.dATAPAGAMENTODataGridViewTextBoxColumn,
            this.oBSERVACAODataGridViewTextBoxColumn,
            this.iDPARCELASDataGridViewTextBoxColumn1});
            this.dgvDebitoParcelas.DataSource = this.dEBITOPARCELASBindingSource;
            this.dgvDebitoParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebitoParcelas.Location = new System.Drawing.Point(0, 0);
            this.dgvDebitoParcelas.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.dgvDebitoParcelas.Name = "dgvDebitoParcelas";
            this.dgvDebitoParcelas.ReadOnly = true;
            this.dgvDebitoParcelas.RowHeadersWidth = 51;
            this.dgvDebitoParcelas.RowTemplate.Height = 24;
            this.dgvDebitoParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebitoParcelas.Size = new System.Drawing.Size(535, 297);
            this.dgvDebitoParcelas.TabIndex = 53;
            // 
            // iDDEBITOPARCELADataGridViewTextBoxColumn
            // 
            this.iDDEBITOPARCELADataGridViewTextBoxColumn.DataPropertyName = "ID_DEBITO_PARCELA";
            this.iDDEBITOPARCELADataGridViewTextBoxColumn.HeaderText = "ID_DEBITO_PARCELA";
            this.iDDEBITOPARCELADataGridViewTextBoxColumn.Name = "iDDEBITOPARCELADataGridViewTextBoxColumn";
            this.iDDEBITOPARCELADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDEBITOPARCELADataGridViewTextBoxColumn.Width = 144;
            // 
            // nUMPARCELADataGridViewTextBoxColumn
            // 
            this.nUMPARCELADataGridViewTextBoxColumn.DataPropertyName = "NUM_PARCELA";
            this.nUMPARCELADataGridViewTextBoxColumn.HeaderText = "NUM_PARCELA";
            this.nUMPARCELADataGridViewTextBoxColumn.Name = "nUMPARCELADataGridViewTextBoxColumn";
            this.nUMPARCELADataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMPARCELADataGridViewTextBoxColumn.Width = 112;
            // 
            // vALORPARCELADataGridViewTextBoxColumn
            // 
            this.vALORPARCELADataGridViewTextBoxColumn.DataPropertyName = "VALOR_PARCELA";
            this.vALORPARCELADataGridViewTextBoxColumn.HeaderText = "VALOR_PARCELA";
            this.vALORPARCELADataGridViewTextBoxColumn.Name = "vALORPARCELADataGridViewTextBoxColumn";
            this.vALORPARCELADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORPARCELADataGridViewTextBoxColumn.Width = 123;
            // 
            // dATAVENCIMENTODataGridViewTextBoxColumn
            // 
            this.dATAVENCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.Name = "dATAVENCIMENTODataGridViewTextBoxColumn";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAVENCIMENTODataGridViewTextBoxColumn.Width = 138;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Width = 75;
            // 
            // dATAPAGAMENTODataGridViewTextBoxColumn
            // 
            this.dATAPAGAMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_PAGAMENTO";
            this.dATAPAGAMENTODataGridViewTextBoxColumn.HeaderText = "DATA_PAGAMENTO";
            this.dATAPAGAMENTODataGridViewTextBoxColumn.Name = "dATAPAGAMENTODataGridViewTextBoxColumn";
            this.dATAPAGAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPAGAMENTODataGridViewTextBoxColumn.Width = 135;
            // 
            // oBSERVACAODataGridViewTextBoxColumn
            // 
            this.oBSERVACAODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn.HeaderText = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn.Name = "oBSERVACAODataGridViewTextBoxColumn";
            this.oBSERVACAODataGridViewTextBoxColumn.ReadOnly = true;
            this.oBSERVACAODataGridViewTextBoxColumn.Width = 105;
            // 
            // iDPARCELASDataGridViewTextBoxColumn1
            // 
            this.iDPARCELASDataGridViewTextBoxColumn1.DataPropertyName = "ID_PARCELAS";
            this.iDPARCELASDataGridViewTextBoxColumn1.HeaderText = "ID_PARCELAS";
            this.iDPARCELASDataGridViewTextBoxColumn1.Name = "iDPARCELASDataGridViewTextBoxColumn1";
            this.iDPARCELASDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDPARCELASDataGridViewTextBoxColumn1.Width = 105;
            // 
            // dEBITOPARCELASBindingSource
            // 
            this.dEBITOPARCELASBindingSource.DataMember = "DEBITO_PARCELAS";
            this.dEBITOPARCELASBindingSource.DataSource = this.dsDadosFinanceiro;
            // 
            // btnPagarParcelaVenda
            // 
            this.btnPagarParcelaVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPagarParcelaVenda.AutoSize = true;
            this.btnPagarParcelaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(213)))), ((int)(((byte)(134)))));
            this.btnPagarParcelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarParcelaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnPagarParcelaVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagarParcelaVenda.Location = new System.Drawing.Point(338, 441);
            this.btnPagarParcelaVenda.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPagarParcelaVenda.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnPagarParcelaVenda.Name = "btnPagarParcelaVenda";
            this.btnPagarParcelaVenda.Size = new System.Drawing.Size(194, 42);
            this.btnPagarParcelaVenda.TabIndex = 55;
            this.btnPagarParcelaVenda.Text = "Pagar Parcela";
            this.btnPagarParcelaVenda.UseVisualStyleBackColor = false;
            this.btnPagarParcelaVenda.Click += new System.EventHandler(this.btnPagarParcelaVenda_Click);
            // 
            // btnLimparFiltroParcelas
            // 
            this.btnLimparFiltroParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparFiltroParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(32)))));
            this.btnLimparFiltroParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltroParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnLimparFiltroParcelas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparFiltroParcelas.Location = new System.Drawing.Point(722, 96);
            this.btnLimparFiltroParcelas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLimparFiltroParcelas.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnLimparFiltroParcelas.MinimumSize = new System.Drawing.Size(74, 27);
            this.btnLimparFiltroParcelas.Name = "btnLimparFiltroParcelas";
            this.btnLimparFiltroParcelas.Size = new System.Drawing.Size(138, 30);
            this.btnLimparFiltroParcelas.TabIndex = 52;
            this.btnLimparFiltroParcelas.Text = "Limpar Filtro";
            this.btnLimparFiltroParcelas.UseVisualStyleBackColor = false;
            this.btnLimparFiltroParcelas.Click += new System.EventHandler(this.btnLimparFiltroParcelas_Click);
            // 
            // txtBuscarParcelas
            // 
            this.txtBuscarParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.txtBuscarParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.txtBuscarParcelas.ForeColor = System.Drawing.Color.White;
            this.txtBuscarParcelas.Location = new System.Drawing.Point(8, 55);
            this.txtBuscarParcelas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscarParcelas.Name = "txtBuscarParcelas";
            this.txtBuscarParcelas.Size = new System.Drawing.Size(339, 29);
            this.txtBuscarParcelas.TabIndex = 45;
            this.txtBuscarParcelas.TextChanged += new System.EventHandler(this.txtBuscarParcelas_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(587, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 40);
            this.label3.TabIndex = 51;
            this.label3.Text = "Buscar parcela:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(382, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 50;
            this.label2.Text = "Filtrar por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "Busca por CPF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAplicarFiltroParcelas
            // 
            this.btnAplicarFiltroParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarFiltroParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnAplicarFiltroParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltroParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAplicarFiltroParcelas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicarFiltroParcelas.Location = new System.Drawing.Point(588, 96);
            this.btnAplicarFiltroParcelas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAplicarFiltroParcelas.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnAplicarFiltroParcelas.MinimumSize = new System.Drawing.Size(74, 27);
            this.btnAplicarFiltroParcelas.Name = "btnAplicarFiltroParcelas";
            this.btnAplicarFiltroParcelas.Size = new System.Drawing.Size(116, 30);
            this.btnAplicarFiltroParcelas.TabIndex = 48;
            this.btnAplicarFiltroParcelas.Text = "Aplicar";
            this.btnAplicarFiltroParcelas.UseVisualStyleBackColor = false;
            this.btnAplicarFiltroParcelas.Click += new System.EventHandler(this.btnAplicarFiltroParcelas_Click);
            // 
            // cmbFiltroParcelas
            // 
            this.cmbFiltroParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbFiltroParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroParcelas.Font = new System.Drawing.Font("Arial", 13.8F);
            this.cmbFiltroParcelas.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroParcelas.FormattingEnabled = true;
            this.cmbFiltroParcelas.Items.AddRange(new object[] {
            "ID_DEBITO_PARCELA",
            "VALOR_PARCELA",
            "STATUS"});
            this.cmbFiltroParcelas.Location = new System.Drawing.Point(388, 55);
            this.cmbFiltroParcelas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbFiltroParcelas.Name = "cmbFiltroParcelas";
            this.cmbFiltroParcelas.Size = new System.Drawing.Size(178, 29);
            this.cmbFiltroParcelas.TabIndex = 46;
            // 
            // dsDadosSaida
            // 
            this.dsDadosSaida.DataSetName = "dsDadosSaida";
            this.dsDadosSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEBITO_PARCELASTableAdapter
            // 
            this.dEBITO_PARCELASTableAdapter.ClearBeforeFill = true;
            // 
            // vw_PARCELAS_CPFTableAdapter
            // 
            this.vw_PARCELAS_CPFTableAdapter.ClearBeforeFill = true;
            // 
            // frmParcelasVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(887, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmParcelasVenda";
            this.Text = "frmParcelasVenda";
            this.Load += new System.EventHandler(this.frmParcelasVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPARCELASCPFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitoParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEBITOPARCELASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTabelaParcelas;
        private Dados.dsDadosSaida dsDadosSaida;
        private System.Windows.Forms.DataGridView dgvDebitoParcelas;
        private System.Windows.Forms.Button btnPagarParcelaVenda;
        private System.Windows.Forms.TextBox txtBuscarParcelas;
        private System.Windows.Forms.Label label1;
        private Dados.dsDadosFinanceiro dsDadosFinanceiro;
        private System.Windows.Forms.BindingSource dEBITOPARCELASBindingSource;
        private Dados.dsDadosFinanceiroTableAdapters.DEBITO_PARCELASTableAdapter dEBITO_PARCELASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEBITOPARCELADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMPARCELADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPARCELADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPAGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPARCELASDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource vwPARCELASCPFBindingSource;
        private Dados.dsDadosFinanceiroTableAdapters.Vw_PARCELAS_CPFTableAdapter vw_PARCELAS_CPFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPARCELASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDPARCELASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSGERALDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBuscarParcela;
        private System.Windows.Forms.Button btnLimparFiltroParcelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAplicarFiltroParcelas;
        private System.Windows.Forms.ComboBox cmbFiltroParcelas;
    }
}