namespace prjMerchades.Formularios.Financeiro
{
    partial class frmRelFinanceiro
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelFinanceiro));
            this.vwRELATORIOFINANCEIRODESPESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosFinanceiro = new prjMerchades.Dados.dsDadosFinanceiro();
            this.vwRELATORIOFINANCEIROGANHOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rELATORIOFINANCEIROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosSaida1 = new prjMerchades.Dados.dsDadosSaida();
            this.dsDadosSaida = new prjMerchades.Dados.dsDadosSaida();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Financeiro = new System.Windows.Forms.TabControl();
            this.tabPage_NF = new System.Windows.Forms.TabPage();
            this.btnGastosLimpar = new System.Windows.Forms.Button();
            this.btnGastosFiltrar = new System.Windows.Forms.Button();
            this.dtpGastosFimPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpGastosInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rvGastos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Linha2 = new System.Windows.Forms.Label();
            this.tabPage_Divida = new System.Windows.Forms.TabPage();
            this.btnVendasLimpar = new System.Windows.Forms.Button();
            this.btnVendasFiltrar = new System.Windows.Forms.Button();
            this.dtpVendasFimPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpVendasInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage_CompraAntg = new System.Windows.Forms.TabPage();
            this.btnGeralLimpar = new System.Windows.Forms.Button();
            this.btnGeralFiltrar = new System.Windows.Forms.Button();
            this.dtpGeralFimPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpGeralInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rvGeral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label7 = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter = new prjMerchades.Dados.dsDadosFinanceiroTableAdapters.Vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter();
            this.vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter = new prjMerchades.Dados.dsDadosFinanceiroTableAdapters.Vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter();
            this.rELATORIO_FINANCEIROTableAdapter = new prjMerchades.Dados.dsDadosFinanceiroTableAdapters.RELATORIO_FINANCEIROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwRELATORIOFINANCEIRODESPESASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRELATORIOFINANCEIROGANHOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rELATORIOFINANCEIROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).BeginInit();
            this.tabControl_Financeiro.SuspendLayout();
            this.tabPage_NF.SuspendLayout();
            this.tabPage_Divida.SuspendLayout();
            this.tabPage_CompraAntg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // vwRELATORIOFINANCEIRODESPESASBindingSource
            // 
            this.vwRELATORIOFINANCEIRODESPESASBindingSource.DataMember = "Vw_RELATORIO_FINANCEIRO_DESPESAS";
            this.vwRELATORIOFINANCEIRODESPESASBindingSource.DataSource = this.dsDadosFinanceiro;
            // 
            // dsDadosFinanceiro
            // 
            this.dsDadosFinanceiro.DataSetName = "dsDadosFinanceiro";
            this.dsDadosFinanceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwRELATORIOFINANCEIROGANHOSBindingSource
            // 
            this.vwRELATORIOFINANCEIROGANHOSBindingSource.DataMember = "Vw_RELATORIO_FINANCEIRO_GANHOS";
            this.vwRELATORIOFINANCEIROGANHOSBindingSource.DataSource = this.dsDadosFinanceiro;
            // 
            // rELATORIOFINANCEIROBindingSource
            // 
            this.rELATORIOFINANCEIROBindingSource.DataMember = "RELATORIO_FINANCEIRO";
            this.rELATORIOFINANCEIROBindingSource.DataSource = this.dsDadosFinanceiro;
            // 
            // dsDadosSaida1
            // 
            this.dsDadosSaida1.DataSetName = "dsDadosSaida";
            this.dsDadosSaida1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDadosSaida
            // 
            this.dsDadosSaida.DataSetName = "dsDadosSaida";
            this.dsDadosSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatório Financeiro ";
            // 
            // tabControl_Financeiro
            // 
            this.tabControl_Financeiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Financeiro.Controls.Add(this.tabPage_NF);
            this.tabControl_Financeiro.Controls.Add(this.tabPage_Divida);
            this.tabControl_Financeiro.Controls.Add(this.tabPage_CompraAntg);
            this.tabControl_Financeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Financeiro.Location = new System.Drawing.Point(0, 98);
            this.tabControl_Financeiro.Name = "tabControl_Financeiro";
            this.tabControl_Financeiro.SelectedIndex = 0;
            this.tabControl_Financeiro.Size = new System.Drawing.Size(1093, 589);
            this.tabControl_Financeiro.TabIndex = 5;
            // 
            // tabPage_NF
            // 
            this.tabPage_NF.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_NF.Controls.Add(this.btnGastosLimpar);
            this.tabPage_NF.Controls.Add(this.btnGastosFiltrar);
            this.tabPage_NF.Controls.Add(this.dtpGastosFimPeriodo);
            this.tabPage_NF.Controls.Add(this.dtpGastosInicioPeriodo);
            this.tabPage_NF.Controls.Add(this.label5);
            this.tabPage_NF.Controls.Add(this.rvGastos);
            this.tabPage_NF.Controls.Add(this.label3);
            this.tabPage_NF.Controls.Add(this.lbl_Linha2);
            this.tabPage_NF.Location = new System.Drawing.Point(4, 29);
            this.tabPage_NF.Name = "tabPage_NF";
            this.tabPage_NF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NF.Size = new System.Drawing.Size(1085, 556);
            this.tabPage_NF.TabIndex = 0;
            this.tabPage_NF.Text = "Gastos";
            // 
            // btnGastosLimpar
            // 
            this.btnGastosLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGastosLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(127)))));
            this.btnGastosLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastosLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnGastosLimpar.Location = new System.Drawing.Point(811, 7);
            this.btnGastosLimpar.Name = "btnGastosLimpar";
            this.btnGastosLimpar.Size = new System.Drawing.Size(122, 38);
            this.btnGastosLimpar.TabIndex = 45;
            this.btnGastosLimpar.Text = "Ver Todos";
            this.btnGastosLimpar.UseVisualStyleBackColor = false;
            this.btnGastosLimpar.Click += new System.EventHandler(this.btnGastosLimpar_Click);
            // 
            // btnGastosFiltrar
            // 
            this.btnGastosFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGastosFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(118)))));
            this.btnGastosFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastosFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnGastosFiltrar.Location = new System.Drawing.Point(950, 7);
            this.btnGastosFiltrar.Name = "btnGastosFiltrar";
            this.btnGastosFiltrar.Size = new System.Drawing.Size(122, 38);
            this.btnGastosFiltrar.TabIndex = 45;
            this.btnGastosFiltrar.Text = "Filtrar";
            this.btnGastosFiltrar.UseVisualStyleBackColor = false;
            this.btnGastosFiltrar.Click += new System.EventHandler(this.btnGastosFiltrar_Click);
            // 
            // dtpGastosFimPeriodo
            // 
            this.dtpGastosFimPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGastosFimPeriodo.Location = new System.Drawing.Point(468, 13);
            this.dtpGastosFimPeriodo.Name = "dtpGastosFimPeriodo";
            this.dtpGastosFimPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpGastosFimPeriodo.TabIndex = 44;
            this.dtpGastosFimPeriodo.Value = new System.DateTime(2025, 11, 17, 23, 59, 0, 0);
            // 
            // dtpGastosInicioPeriodo
            // 
            this.dtpGastosInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGastosInicioPeriodo.Location = new System.Drawing.Point(282, 13);
            this.dtpGastosInicioPeriodo.Name = "dtpGastosInicioPeriodo";
            this.dtpGastosInicioPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpGastosInicioPeriodo.TabIndex = 44;
            this.dtpGastosInicioPeriodo.Value = new System.DateTime(2025, 11, 17, 0, 0, 0, 0);
            this.dtpGastosInicioPeriodo.ValueChanged += new System.EventHandler(this.dtpGastosInicioPeriodo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "até";
            // 
            // rvGastos
            // 
            this.rvGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetReportViewerRelatorioFinanceiro";
            reportDataSource1.Value = this.vwRELATORIOFINANCEIRODESPESASBindingSource;
            this.rvGastos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGastos.LocalReport.ReportEmbeddedResource = "prjMerchades.Formularios.Financeiro.ReportFinanceiro.rdlc";
            this.rvGastos.Location = new System.Drawing.Point(3, 66);
            this.rvGastos.Name = "rvGastos";
            this.rvGastos.ServerReport.BearerToken = null;
            this.rvGastos.Size = new System.Drawing.Size(1077, 506);
            this.rvGastos.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Selecione o período desejado :";
            // 
            // lbl_Linha2
            // 
            this.lbl_Linha2.AutoSize = true;
            this.lbl_Linha2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Linha2.Location = new System.Drawing.Point(25, 464);
            this.lbl_Linha2.Name = "lbl_Linha2";
            this.lbl_Linha2.Size = new System.Drawing.Size(1149, 20);
            this.lbl_Linha2.TabIndex = 34;
            this.lbl_Linha2.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // tabPage_Divida
            // 
            this.tabPage_Divida.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_Divida.Controls.Add(this.btnVendasLimpar);
            this.tabPage_Divida.Controls.Add(this.btnVendasFiltrar);
            this.tabPage_Divida.Controls.Add(this.dtpVendasFimPeriodo);
            this.tabPage_Divida.Controls.Add(this.dtpVendasInicioPeriodo);
            this.tabPage_Divida.Controls.Add(this.label2);
            this.tabPage_Divida.Controls.Add(this.rvVendas);
            this.tabPage_Divida.Controls.Add(this.label6);
            this.tabPage_Divida.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Divida.Name = "tabPage_Divida";
            this.tabPage_Divida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Divida.Size = new System.Drawing.Size(1085, 556);
            this.tabPage_Divida.TabIndex = 1;
            this.tabPage_Divida.Text = "Vendas";
            // 
            // btnVendasLimpar
            // 
            this.btnVendasLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendasLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(127)))));
            this.btnVendasLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnVendasLimpar.Location = new System.Drawing.Point(805, 5);
            this.btnVendasLimpar.Name = "btnVendasLimpar";
            this.btnVendasLimpar.Size = new System.Drawing.Size(122, 38);
            this.btnVendasLimpar.TabIndex = 52;
            this.btnVendasLimpar.Text = "Ver Todos";
            this.btnVendasLimpar.UseVisualStyleBackColor = false;
            this.btnVendasLimpar.Click += new System.EventHandler(this.btnVendasLimpar_Click);
            // 
            // btnVendasFiltrar
            // 
            this.btnVendasFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendasFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(118)))));
            this.btnVendasFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasFiltrar.Location = new System.Drawing.Point(951, 5);
            this.btnVendasFiltrar.Name = "btnVendasFiltrar";
            this.btnVendasFiltrar.Size = new System.Drawing.Size(122, 38);
            this.btnVendasFiltrar.TabIndex = 51;
            this.btnVendasFiltrar.Text = "Filtrar";
            this.btnVendasFiltrar.UseVisualStyleBackColor = false;
            this.btnVendasFiltrar.Click += new System.EventHandler(this.btnVendasFiltrar_Click);
            // 
            // dtpVendasFimPeriodo
            // 
            this.dtpVendasFimPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVendasFimPeriodo.Location = new System.Drawing.Point(469, 11);
            this.dtpVendasFimPeriodo.Name = "dtpVendasFimPeriodo";
            this.dtpVendasFimPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpVendasFimPeriodo.TabIndex = 49;
            this.dtpVendasFimPeriodo.Value = new System.DateTime(2025, 11, 17, 23, 59, 0, 0);
            // 
            // dtpVendasInicioPeriodo
            // 
            this.dtpVendasInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVendasInicioPeriodo.Location = new System.Drawing.Point(283, 11);
            this.dtpVendasInicioPeriodo.Name = "dtpVendasInicioPeriodo";
            this.dtpVendasInicioPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpVendasInicioPeriodo.TabIndex = 50;
            this.dtpVendasInicioPeriodo.Value = new System.DateTime(2025, 11, 17, 0, 0, 0, 0);
            this.dtpVendasInicioPeriodo.ValueChanged += new System.EventHandler(this.dtpVendasInicioPeriodo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "até";
            // 
            // rvVendas
            // 
            this.rvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSetReportViewerRelatorioFinanceiro";
            reportDataSource2.Value = this.vwRELATORIOFINANCEIROGANHOSBindingSource;
            this.rvVendas.LocalReport.DataSources.Add(reportDataSource2);
            this.rvVendas.LocalReport.ReportEmbeddedResource = "prjMerchades.Formularios.Financeiro.ReportFinanceiro.rdlc";
            this.rvVendas.Location = new System.Drawing.Point(4, 64);
            this.rvVendas.Name = "rvVendas";
            this.rvVendas.ServerReport.BearerToken = null;
            this.rvVendas.Size = new System.Drawing.Size(1077, 506);
            this.rvVendas.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Selecione o período desejado :";
            // 
            // tabPage_CompraAntg
            // 
            this.tabPage_CompraAntg.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_CompraAntg.Controls.Add(this.btnGeralLimpar);
            this.tabPage_CompraAntg.Controls.Add(this.btnGeralFiltrar);
            this.tabPage_CompraAntg.Controls.Add(this.dtpGeralFimPeriodo);
            this.tabPage_CompraAntg.Controls.Add(this.dtpGeralInicioPeriodo);
            this.tabPage_CompraAntg.Controls.Add(this.label4);
            this.tabPage_CompraAntg.Controls.Add(this.rvGeral);
            this.tabPage_CompraAntg.Controls.Add(this.label7);
            this.tabPage_CompraAntg.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CompraAntg.Name = "tabPage_CompraAntg";
            this.tabPage_CompraAntg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CompraAntg.Size = new System.Drawing.Size(1085, 556);
            this.tabPage_CompraAntg.TabIndex = 2;
            this.tabPage_CompraAntg.Text = "Geral";
            // 
            // btnGeralLimpar
            // 
            this.btnGeralLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeralLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(127)))));
            this.btnGeralLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeralLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnGeralLimpar.Location = new System.Drawing.Point(804, 5);
            this.btnGeralLimpar.Name = "btnGeralLimpar";
            this.btnGeralLimpar.Size = new System.Drawing.Size(122, 38);
            this.btnGeralLimpar.TabIndex = 58;
            this.btnGeralLimpar.Text = "Ver Todos";
            this.btnGeralLimpar.UseVisualStyleBackColor = false;
            this.btnGeralLimpar.Click += new System.EventHandler(this.btnGeralLimpar_Click);
            // 
            // btnGeralFiltrar
            // 
            this.btnGeralFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeralFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(118)))));
            this.btnGeralFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeralFiltrar.Location = new System.Drawing.Point(951, 5);
            this.btnGeralFiltrar.Name = "btnGeralFiltrar";
            this.btnGeralFiltrar.Size = new System.Drawing.Size(122, 38);
            this.btnGeralFiltrar.TabIndex = 57;
            this.btnGeralFiltrar.Text = "Filtrar";
            this.btnGeralFiltrar.UseVisualStyleBackColor = false;
            this.btnGeralFiltrar.Click += new System.EventHandler(this.btnGeralFiltrar_Click);
            // 
            // dtpGeralFimPeriodo
            // 
            this.dtpGeralFimPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeralFimPeriodo.Location = new System.Drawing.Point(469, 11);
            this.dtpGeralFimPeriodo.Name = "dtpGeralFimPeriodo";
            this.dtpGeralFimPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpGeralFimPeriodo.TabIndex = 55;
            this.dtpGeralFimPeriodo.Value = new System.DateTime(2025, 11, 17, 23, 59, 0, 0);
            // 
            // dtpGeralInicioPeriodo
            // 
            this.dtpGeralInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeralInicioPeriodo.Location = new System.Drawing.Point(283, 11);
            this.dtpGeralInicioPeriodo.Name = "dtpGeralInicioPeriodo";
            this.dtpGeralInicioPeriodo.Size = new System.Drawing.Size(139, 26);
            this.dtpGeralInicioPeriodo.TabIndex = 56;
            this.dtpGeralInicioPeriodo.Value = new System.DateTime(2025, 11, 17, 0, 0, 0, 0);
            this.dtpGeralInicioPeriodo.ValueChanged += new System.EventHandler(this.dtpGeralInicioPeriodo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "até";
            // 
            // rvGeral
            // 
            this.rvGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSetReportViewerRelatorioFinanceiro";
            reportDataSource3.Value = this.rELATORIOFINANCEIROBindingSource;
            this.rvGeral.LocalReport.DataSources.Add(reportDataSource3);
            this.rvGeral.LocalReport.ReportEmbeddedResource = "prjMerchades.Formularios.Financeiro.ReportFinanceiro.rdlc";
            this.rvGeral.Location = new System.Drawing.Point(4, 64);
            this.rvGeral.Name = "rvGeral";
            this.rvGeral.ServerReport.BearerToken = null;
            this.rvGeral.Size = new System.Drawing.Size(1077, 506);
            this.rvGeral.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Selecione o período desejado :";
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(964, 5);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(100, 87);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 7;
            this.picBox_Logo.TabStop = false;
            // 
            // vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter
            // 
            this.vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter.ClearBeforeFill = true;
            // 
            // vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter
            // 
            this.vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter.ClearBeforeFill = true;
            // 
            // rELATORIO_FINANCEIROTableAdapter
            // 
            this.rELATORIO_FINANCEIROTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1093, 687);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl_Financeiro);
            this.Name = "frmRelFinanceiro";
            this.Text = "Relatórios Financeiros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwRELATORIOFINANCEIRODESPESASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRELATORIOFINANCEIROGANHOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rELATORIOFINANCEIROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).EndInit();
            this.tabControl_Financeiro.ResumeLayout(false);
            this.tabPage_NF.ResumeLayout(false);
            this.tabPage_NF.PerformLayout();
            this.tabPage_Divida.ResumeLayout(false);
            this.tabPage_Divida.PerformLayout();
            this.tabPage_CompraAntg.ResumeLayout(false);
            this.tabPage_CompraAntg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_Financeiro;
        private System.Windows.Forms.TabPage tabPage_NF;
        private System.Windows.Forms.Label lbl_Linha2;
        private System.Windows.Forms.TabPage tabPage_Divida;
        private System.Windows.Forms.TabPage tabPage_CompraAntg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGastosFimPeriodo;
        private System.Windows.Forms.DateTimePicker dtpGastosInicioPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGastosFiltrar;
        private System.Windows.Forms.Button btnVendasFiltrar;
        private System.Windows.Forms.DateTimePicker dtpVendasFimPeriodo;
        private System.Windows.Forms.DateTimePicker dtpVendasInicioPeriodo;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvVendas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGeralFiltrar;
        private System.Windows.Forms.DateTimePicker dtpGeralFimPeriodo;
        private System.Windows.Forms.DateTimePicker dtpGeralInicioPeriodo;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer rvGeral;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer rvGastos;
        private Dados.dsDadosSaida dsDadosSaida;
        private Dados.dsDadosSaida dsDadosSaida1;
        private System.Windows.Forms.Button btnGastosLimpar;
        private System.Windows.Forms.Button btnVendasLimpar;
        private System.Windows.Forms.Button btnGeralLimpar;
        private Dados.dsDadosFinanceiro dsDadosFinanceiro;
        private System.Windows.Forms.BindingSource vwRELATORIOFINANCEIRODESPESASBindingSource;
        private Dados.dsDadosFinanceiroTableAdapters.Vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter;
        private System.Windows.Forms.BindingSource vwRELATORIOFINANCEIROGANHOSBindingSource;
        private Dados.dsDadosFinanceiroTableAdapters.Vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter;
        private System.Windows.Forms.BindingSource rELATORIOFINANCEIROBindingSource;
        private Dados.dsDadosFinanceiroTableAdapters.RELATORIO_FINANCEIROTableAdapter rELATORIO_FINANCEIROTableAdapter;
    }
}