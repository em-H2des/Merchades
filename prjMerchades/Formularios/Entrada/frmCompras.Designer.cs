namespace prjMerchades.Formularios.Entrada
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.tabControl_Compras = new System.Windows.Forms.TabControl();
            this.tabPage_NF = new System.Windows.Forms.TabPage();
            this.lbl_Linha2 = new System.Windows.Forms.Label();
            this.lbl_Linha1 = new System.Windows.Forms.Label();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.lbl_TipoProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbl_NomeProduto = new System.Windows.Forms.Label();
            this.txtCodNF = new System.Windows.Forms.TextBox();
            this.lbl_CodNF = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbl_DataEmissao = new System.Windows.Forms.Label();
            this.dateEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lbl_CodFornecedor = new System.Windows.Forms.Label();
            this.txtVlrTtl = new System.Windows.Forms.TextBox();
            this.lbl_VlrTtl = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.lbl_DataVldd = new System.Windows.Forms.Label();
            this.dateValidade = new System.Windows.Forms.DateTimePicker();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lbl_Lote = new System.Windows.Forms.Label();
            this.lbl_Qtd = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lbl_CodBarras = new System.Windows.Forms.Label();
            this.tabPage_Divida = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraDividasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daDadosEntrada2 = new prjMerchades.Dados.daDadosEntrada();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Data2 = new System.Windows.Forms.Label();
            this.tabPage_CompraAntg = new System.Windows.Forms.TabPage();
            this.btnBuscarAntigas = new System.Windows.Forms.Button();
            this.cmbFiltroAntigas = new System.Windows.Forms.ComboBox();
            this.txtFiltroAntigas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.nOTAFISCALFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daDadosEntrada = new prjMerchades.Dados.daDadosEntrada();
            this.nOTA_FISCAL_FORNECEDORTableAdapter = new prjMerchades.Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter();
            this.daDadosEntrada1 = new prjMerchades.Dados.daDadosEntrada();
            this.compraDividasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraDividasTableAdapter = new prjMerchades.Dados.daDadosEntradaTableAdapters.compraDividasTableAdapter();
            this.cmbTipoUnitario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl_Compras.SuspendLayout();
            this.tabPage_NF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.tabPage_Divida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada2)).BeginInit();
            this.tabPage_CompraAntg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALFORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Compras
            // 
            this.tabControl_Compras.Controls.Add(this.tabPage_NF);
            this.tabControl_Compras.Controls.Add(this.tabPage_Divida);
            this.tabControl_Compras.Controls.Add(this.tabPage_CompraAntg);
            this.tabControl_Compras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Compras.Location = new System.Drawing.Point(0, 74);
            this.tabControl_Compras.Name = "tabControl_Compras";
            this.tabControl_Compras.SelectedIndex = 0;
            this.tabControl_Compras.Size = new System.Drawing.Size(1093, 608);
            this.tabControl_Compras.TabIndex = 0;
            // 
            // tabPage_NF
            // 
            this.tabPage_NF.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_NF.Controls.Add(this.label4);
            this.tabPage_NF.Controls.Add(this.cmbTipoUnitario);
            this.tabPage_NF.Controls.Add(this.lbl_Linha2);
            this.tabPage_NF.Controls.Add(this.lbl_Linha1);
            this.tabPage_NF.Controls.Add(this.txtTipoProduto);
            this.tabPage_NF.Controls.Add(this.lbl_TipoProduto);
            this.tabPage_NF.Controls.Add(this.txtNomeProduto);
            this.tabPage_NF.Controls.Add(this.lbl_NomeProduto);
            this.tabPage_NF.Controls.Add(this.txtCodNF);
            this.tabPage_NF.Controls.Add(this.lbl_CodNF);
            this.tabPage_NF.Controls.Add(this.btnEnviar);
            this.tabPage_NF.Controls.Add(this.lbl_DataEmissao);
            this.tabPage_NF.Controls.Add(this.dateEmissao);
            this.tabPage_NF.Controls.Add(this.txtCodFornecedor);
            this.tabPage_NF.Controls.Add(this.lbl_CodFornecedor);
            this.tabPage_NF.Controls.Add(this.txtVlrTtl);
            this.tabPage_NF.Controls.Add(this.lbl_VlrTtl);
            this.tabPage_NF.Controls.Add(this.txtPreco);
            this.tabPage_NF.Controls.Add(this.lbl_Preco);
            this.tabPage_NF.Controls.Add(this.lbl_DataVldd);
            this.tabPage_NF.Controls.Add(this.dateValidade);
            this.tabPage_NF.Controls.Add(this.txtLote);
            this.tabPage_NF.Controls.Add(this.lbl_Lote);
            this.tabPage_NF.Controls.Add(this.lbl_Qtd);
            this.tabPage_NF.Controls.Add(this.numQtd);
            this.tabPage_NF.Controls.Add(this.txtCodBarras);
            this.tabPage_NF.Controls.Add(this.lbl_CodBarras);
            this.tabPage_NF.Location = new System.Drawing.Point(4, 29);
            this.tabPage_NF.Name = "tabPage_NF";
            this.tabPage_NF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NF.Size = new System.Drawing.Size(1085, 575);
            this.tabPage_NF.TabIndex = 0;
            this.tabPage_NF.Text = "Receber Nota Fiscal";
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
            // lbl_Linha1
            // 
            this.lbl_Linha1.AutoSize = true;
            this.lbl_Linha1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Linha1.Location = new System.Drawing.Point(25, 134);
            this.lbl_Linha1.Name = "lbl_Linha1";
            this.lbl_Linha1.Size = new System.Drawing.Size(1149, 20);
            this.lbl_Linha1.TabIndex = 33;
            this.lbl_Linha1.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Location = new System.Drawing.Point(355, 211);
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(194, 26);
            this.txtTipoProduto.TabIndex = 32;
            // 
            // lbl_TipoProduto
            // 
            this.lbl_TipoProduto.AutoSize = true;
            this.lbl_TipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_TipoProduto.Location = new System.Drawing.Point(349, 177);
            this.lbl_TipoProduto.Name = "lbl_TipoProduto";
            this.lbl_TipoProduto.Size = new System.Drawing.Size(187, 25);
            this.lbl_TipoProduto.TabIndex = 31;
            this.lbl_TipoProduto.Text = "Tipo de Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(92, 211);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(237, 26);
            this.txtNomeProduto.TabIndex = 30;
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.AutoSize = true;
            this.lbl_NomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_NomeProduto.Location = new System.Drawing.Point(86, 177);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(168, 25);
            this.lbl_NomeProduto.TabIndex = 29;
            this.lbl_NomeProduto.Text = "Nome Produto:";
            // 
            // txtCodNF
            // 
            this.txtCodNF.Location = new System.Drawing.Point(92, 413);
            this.txtCodNF.Name = "txtCodNF";
            this.txtCodNF.Size = new System.Drawing.Size(225, 26);
            this.txtCodNF.TabIndex = 28;
            // 
            // lbl_CodNF
            // 
            this.lbl_CodNF.AutoSize = true;
            this.lbl_CodNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodNF.Location = new System.Drawing.Point(86, 379);
            this.lbl_CodNF.Name = "lbl_CodNF";
            this.lbl_CodNF.Size = new System.Drawing.Size(252, 25);
            this.lbl_CodNF.TabIndex = 27;
            this.lbl_CodNF.Text = "Código da Nota Fiscal:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.Location = new System.Drawing.Point(871, 404);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(122, 41);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbl_DataEmissao
            // 
            this.lbl_DataEmissao.AutoSize = true;
            this.lbl_DataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_DataEmissao.Location = new System.Drawing.Point(808, 273);
            this.lbl_DataEmissao.Name = "lbl_DataEmissao";
            this.lbl_DataEmissao.Size = new System.Drawing.Size(197, 25);
            this.lbl_DataEmissao.TabIndex = 17;
            this.lbl_DataEmissao.Text = "Data de Emissão:";
            // 
            // dateEmissao
            // 
            this.dateEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmissao.Location = new System.Drawing.Point(814, 309);
            this.dateEmissao.Name = "dateEmissao";
            this.dateEmissao.Size = new System.Drawing.Size(140, 29);
            this.dateEmissao.TabIndex = 16;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(92, 87);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(237, 26);
            this.txtCodFornecedor.TabIndex = 13;
            // 
            // lbl_CodFornecedor
            // 
            this.lbl_CodFornecedor.AutoSize = true;
            this.lbl_CodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodFornecedor.Location = new System.Drawing.Point(86, 53);
            this.lbl_CodFornecedor.Name = "lbl_CodFornecedor";
            this.lbl_CodFornecedor.Size = new System.Drawing.Size(253, 25);
            this.lbl_CodFornecedor.TabIndex = 12;
            this.lbl_CodFornecedor.Text = "Código do Fornecedor:";
            // 
            // txtVlrTtl
            // 
            this.txtVlrTtl.Location = new System.Drawing.Point(365, 413);
            this.txtVlrTtl.Name = "txtVlrTtl";
            this.txtVlrTtl.Size = new System.Drawing.Size(237, 26);
            this.txtVlrTtl.TabIndex = 11;
            // 
            // lbl_VlrTtl
            // 
            this.lbl_VlrTtl.AutoSize = true;
            this.lbl_VlrTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VlrTtl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_VlrTtl.Location = new System.Drawing.Point(359, 379);
            this.lbl_VlrTtl.Name = "lbl_VlrTtl";
            this.lbl_VlrTtl.Size = new System.Drawing.Size(134, 25);
            this.lbl_VlrTtl.TabIndex = 10;
            this.lbl_VlrTtl.Text = "Valor Total:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(571, 211);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(120, 26);
            this.txtPreco.TabIndex = 9;
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Preco.Location = new System.Drawing.Point(565, 177);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(80, 25);
            this.lbl_Preco.TabIndex = 8;
            this.lbl_Preco.Text = "Preço:";
            // 
            // lbl_DataVldd
            // 
            this.lbl_DataVldd.AutoSize = true;
            this.lbl_DataVldd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataVldd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_DataVldd.Location = new System.Drawing.Point(809, 177);
            this.lbl_DataVldd.Name = "lbl_DataVldd";
            this.lbl_DataVldd.Size = new System.Drawing.Size(200, 25);
            this.lbl_DataVldd.TabIndex = 7;
            this.lbl_DataVldd.Text = "Data de Validade:";
            // 
            // dateValidade
            // 
            this.dateValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateValidade.Location = new System.Drawing.Point(815, 211);
            this.dateValidade.Name = "dateValidade";
            this.dateValidade.Size = new System.Drawing.Size(139, 29);
            this.dateValidade.TabIndex = 6;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(560, 307);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(232, 26);
            this.txtLote.TabIndex = 5;
            // 
            // lbl_Lote
            // 
            this.lbl_Lote.AutoSize = true;
            this.lbl_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Lote.Location = new System.Drawing.Point(554, 273);
            this.lbl_Lote.Name = "lbl_Lote";
            this.lbl_Lote.Size = new System.Drawing.Size(65, 25);
            this.lbl_Lote.TabIndex = 4;
            this.lbl_Lote.Text = "Lote:";
            // 
            // lbl_Qtd
            // 
            this.lbl_Qtd.AutoSize = true;
            this.lbl_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Qtd.Location = new System.Drawing.Point(708, 177);
            this.lbl_Qtd.Name = "lbl_Qtd";
            this.lbl_Qtd.Size = new System.Drawing.Size(56, 25);
            this.lbl_Qtd.TabIndex = 3;
            this.lbl_Qtd.Text = "Qtd:";
            // 
            // numQtd
            // 
            this.numQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd.Location = new System.Drawing.Point(714, 211);
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(77, 29);
            this.numQtd.TabIndex = 2;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(335, 307);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(196, 26);
            this.txtCodBarras.TabIndex = 1;
            // 
            // lbl_CodBarras
            // 
            this.lbl_CodBarras.AutoSize = true;
            this.lbl_CodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodBarras.Location = new System.Drawing.Point(329, 273);
            this.lbl_CodBarras.Name = "lbl_CodBarras";
            this.lbl_CodBarras.Size = new System.Drawing.Size(209, 25);
            this.lbl_CodBarras.TabIndex = 0;
            this.lbl_CodBarras.Text = "Código de Barras: ";
            // 
            // tabPage_Divida
            // 
            this.tabPage_Divida.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_Divida.Controls.Add(this.dataGridView1);
            this.tabPage_Divida.Controls.Add(this.btnBuscar);
            this.tabPage_Divida.Controls.Add(this.cmbFiltro);
            this.tabPage_Divida.Controls.Add(this.txtFiltro);
            this.tabPage_Divida.Controls.Add(this.label2);
            this.tabPage_Divida.Controls.Add(this.lbl_Data2);
            this.tabPage_Divida.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Divida.Name = "tabPage_Divida";
            this.tabPage_Divida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Divida.Size = new System.Drawing.Size(1085, 575);
            this.tabPage_Divida.TabIndex = 1;
            this.tabPage_Divida.Text = "Dívidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeFornecedor,
            this.colValor,
            this.colData,
            this.colObs});
            this.dataGridView1.DataSource = this.compraDividasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1085, 487);
            this.dataGridView1.TabIndex = 31;
            // 
            // colNomeFornecedor
            // 
            this.colNomeFornecedor.DataPropertyName = "NOME_FORNECEDOR";
            this.colNomeFornecedor.HeaderText = "NOME_FORNECEDOR";
            this.colNomeFornecedor.Name = "colNomeFornecedor";
            this.colNomeFornecedor.Width = 250;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VALOR_COMPRA";
            this.colValor.HeaderText = "VALOR_COMPRA";
            this.colValor.Name = "colValor";
            this.colValor.Width = 200;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA_EMISSAO";
            this.colData.HeaderText = "DATA_EMISSAO";
            this.colData.Name = "colData";
            this.colData.Width = 150;
            // 
            // colObs
            // 
            this.colObs.DataPropertyName = "OBSERVACAO";
            this.colObs.HeaderText = "OBSERVACAO";
            this.colObs.Name = "colObs";
            this.colObs.Width = 400;
            // 
            // compraDividasBindingSource1
            // 
            this.compraDividasBindingSource1.DataMember = "compraDividas";
            this.compraDividasBindingSource1.DataSource = this.daDadosEntrada2;
            // 
            // daDadosEntrada2
            // 
            this.daDadosEntrada2.DataSetName = "daDadosEntrada";
            this.daDadosEntrada2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(716, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 30);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Data",
            "Valor",
            "Fornecedor"});
            this.cmbFiltro.Location = new System.Drawing.Point(149, 33);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(217, 32);
            this.cmbFiltro.TabIndex = 28;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtFiltro.Location = new System.Drawing.Point(391, 34);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(263, 31);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.Text = "Texto Filtrador Ex:(14/07/2000)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filtrar Por:";
            // 
            // lbl_Data2
            // 
            this.lbl_Data2.AutoSize = true;
            this.lbl_Data2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.lbl_Data2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data2.ForeColor = System.Drawing.Color.White;
            this.lbl_Data2.Location = new System.Drawing.Point(950, 36);
            this.lbl_Data2.Name = "lbl_Data2";
            this.lbl_Data2.Size = new System.Drawing.Size(110, 25);
            this.lbl_Data2.TabIndex = 24;
            this.lbl_Data2.Text = "              ";
            // 
            // tabPage_CompraAntg
            // 
            this.tabPage_CompraAntg.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_CompraAntg.Controls.Add(this.btnBuscarAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.cmbFiltroAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.txtFiltroAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.label3);
            this.tabPage_CompraAntg.Controls.Add(this.dataGridView2);
            this.tabPage_CompraAntg.Controls.Add(this.lbl_Data);
            this.tabPage_CompraAntg.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CompraAntg.Name = "tabPage_CompraAntg";
            this.tabPage_CompraAntg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CompraAntg.Size = new System.Drawing.Size(1085, 575);
            this.tabPage_CompraAntg.TabIndex = 2;
            this.tabPage_CompraAntg.Text = "Compras antigas";
            // 
            // btnBuscarAntigas
            // 
            this.btnBuscarAntigas.Location = new System.Drawing.Point(750, 35);
            this.btnBuscarAntigas.Name = "btnBuscarAntigas";
            this.btnBuscarAntigas.Size = new System.Drawing.Size(99, 30);
            this.btnBuscarAntigas.TabIndex = 36;
            this.btnBuscarAntigas.Text = "Buscar";
            this.btnBuscarAntigas.UseVisualStyleBackColor = true;
            this.btnBuscarAntigas.Click += new System.EventHandler(this.btnBuscarAntigas_Click);
            // 
            // cmbFiltroAntigas
            // 
            this.cmbFiltroAntigas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroAntigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroAntigas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbFiltroAntigas.FormattingEnabled = true;
            this.cmbFiltroAntigas.Items.AddRange(new object[] {
            "Data",
            "Valor",
            "Fornecedor"});
            this.cmbFiltroAntigas.Location = new System.Drawing.Point(183, 33);
            this.cmbFiltroAntigas.Name = "cmbFiltroAntigas";
            this.cmbFiltroAntigas.Size = new System.Drawing.Size(217, 32);
            this.cmbFiltroAntigas.TabIndex = 35;
            // 
            // txtFiltroAntigas
            // 
            this.txtFiltroAntigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAntigas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtFiltroAntigas.Location = new System.Drawing.Point(425, 34);
            this.txtFiltroAntigas.Multiline = true;
            this.txtFiltroAntigas.Name = "txtFiltroAntigas";
            this.txtFiltroAntigas.Size = new System.Drawing.Size(263, 31);
            this.txtFiltroAntigas.TabIndex = 34;
            this.txtFiltroAntigas.Text = "Texto Filtrador Ex:(14/07/2000)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(41, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filtrar Por:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.compraDividasBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1085, 487);
            this.dataGridView2.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOME_FORNECEDOR";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOME_FORNECEDOR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VALOR_COMPRA";
            this.dataGridViewTextBoxColumn2.HeaderText = "VALOR_COMPRA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA_EMISSAO";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATA_EMISSAO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OBSERVACAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "OBSERVACAO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ForeColor = System.Drawing.Color.White;
            this.lbl_Data.Location = new System.Drawing.Point(945, 35);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(110, 25);
            this.lbl_Data.TabIndex = 19;
            this.lbl_Data.Text = "              ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compras";
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(964, 9);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(100, 87);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 4;
            this.picBox_Logo.TabStop = false;
            // 
            // nOTAFISCALFORNECEDORBindingSource
            // 
            this.nOTAFISCALFORNECEDORBindingSource.DataMember = "NOTA_FISCAL_FORNECEDOR";
            this.nOTAFISCALFORNECEDORBindingSource.DataSource = this.daDadosEntrada;
            // 
            // daDadosEntrada
            // 
            this.daDadosEntrada.DataSetName = "daDadosEntrada";
            this.daDadosEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOTA_FISCAL_FORNECEDORTableAdapter
            // 
            this.nOTA_FISCAL_FORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // daDadosEntrada1
            // 
            this.daDadosEntrada1.DataSetName = "daDadosEntrada";
            this.daDadosEntrada1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraDividasBindingSource
            // 
            this.compraDividasBindingSource.DataSource = this.daDadosEntrada1;
            this.compraDividasBindingSource.Position = 0;
            // 
            // compraDividasTableAdapter
            // 
            this.compraDividasTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTipoUnitario
            // 
            this.cmbTipoUnitario.FormattingEnabled = true;
            this.cmbTipoUnitario.Items.AddRange(new object[] {
            "Grama",
            "Quilograma",
            "Mililitro",
            "Litro",
            "Fardo"});
            this.cmbTipoUnitario.Location = new System.Drawing.Point(91, 307);
            this.cmbTipoUnitario.Name = "cmbTipoUnitario";
            this.cmbTipoUnitario.Size = new System.Drawing.Size(216, 28);
            this.cmbTipoUnitario.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(87, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tipo Unitario:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl_Compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.tabControl_Compras.ResumeLayout(false);
            this.tabPage_NF.ResumeLayout(false);
            this.tabPage_NF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.tabPage_Divida.ResumeLayout(false);
            this.tabPage_Divida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada2)).EndInit();
            this.tabPage_CompraAntg.ResumeLayout(false);
            this.tabPage_CompraAntg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALFORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Compras;
        private System.Windows.Forms.TabPage tabPage_NF;
        private System.Windows.Forms.TabPage tabPage_Divida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_CompraAntg;
        private System.Windows.Forms.Label lbl_CodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lbl_Qtd;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Label lbl_DataVldd;
        private System.Windows.Forms.DateTimePicker dateValidade;
        private System.Windows.Forms.TextBox txtVlrTtl;
        private System.Windows.Forms.Label lbl_VlrTtl;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lbl_CodFornecedor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.Label lbl_TipoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lbl_NomeProduto;
        private System.Windows.Forms.TextBox txtCodNF;
        private System.Windows.Forms.Label lbl_CodNF;
        private System.Windows.Forms.Label lbl_DataEmissao;
        private System.Windows.Forms.DateTimePicker dateEmissao;
        private System.Windows.Forms.Label lbl_Linha1;
        private System.Windows.Forms.Label lbl_Linha2;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Data2;
        private Dados.daDadosEntrada daDadosEntrada;
        private System.Windows.Forms.BindingSource nOTAFISCALFORNECEDORBindingSource;
        private Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter nOTA_FISCAL_FORNECEDORTableAdapter;
        private Dados.daDadosEntrada daDadosEntrada1;
        private System.Windows.Forms.BindingSource compraDividasBindingSource;
        private Dados.daDadosEntradaTableAdapters.compraDividasTableAdapter compraDividasTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Dados.daDadosEntrada daDadosEntrada2;
        private System.Windows.Forms.BindingSource compraDividasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnBuscarAntigas;
        private System.Windows.Forms.ComboBox cmbFiltroAntigas;
        private System.Windows.Forms.TextBox txtFiltroAntigas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoUnitario;
    }
}