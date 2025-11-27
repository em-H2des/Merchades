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
            this.dtvwComprasNF = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnCamposNF = new System.Windows.Forms.Panel();
            this.lbl_CodFornecedor = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lbl_CodNF = new System.Windows.Forms.Label();
            this.txtCodNF = new System.Windows.Forms.TextBox();
            this.lbl_DataEmissao = new System.Windows.Forms.Label();
            this.dateEmissao = new System.Windows.Forms.DateTimePicker();
            this.btnProximo = new System.Windows.Forms.Button();
            this.pnCamposItens = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_NomeProduto = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.lbl_Qtd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQtdACad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoUnitario = new System.Windows.Forms.ComboBox();
            this.dateValidade = new System.Windows.Forms.DateTimePicker();
            this.lbl_DataVldd = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbl_TipoProduto = new System.Windows.Forms.Label();
            this.lbl_Lote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lbl_CodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lbl_Linha2 = new System.Windows.Forms.Label();
            this.lbl_Linha1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtVlrTtl = new System.Windows.Forms.TextBox();
            this.lbl_VlrTtl = new System.Windows.Forms.Label();
            this.tabPage_Divida = new System.Windows.Forms.TabPage();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAEMISSAODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCOMPRADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraDividasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daDadosEntrada = new prjMerchades.Dados.daDadosEntrada();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Data2 = new System.Windows.Forms.Label();
            this.tabPage_CompraAntg = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarAntigas = new System.Windows.Forms.Button();
            this.cmbFiltroAntigas = new System.Windows.Forms.ComboBox();
            this.txtFiltroAntigas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFORNECEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAEMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasAntigasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.nOTAFISCALFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOTA_FISCAL_FORNECEDORTableAdapter = new prjMerchades.Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter();
            this.comprasAntigasTableAdapter = new prjMerchades.Dados.daDadosEntradaTableAdapters.comprasAntigasTableAdapter();
            this.compraDividasTableAdapter = new prjMerchades.Dados.daDadosEntradaTableAdapters.compraDividasTableAdapter();
            this.tabControl_Compras.SuspendLayout();
            this.tabPage_NF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvwComprasNF)).BeginInit();
            this.pnCamposNF.SuspendLayout();
            this.pnCamposItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdACad)).BeginInit();
            this.tabPage_Divida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada)).BeginInit();
            this.tabPage_CompraAntg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasAntigasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALFORNECEDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Compras
            // 
            this.tabControl_Compras.Controls.Add(this.tabPage_NF);
            this.tabControl_Compras.Controls.Add(this.tabPage_Divida);
            this.tabControl_Compras.Controls.Add(this.tabPage_CompraAntg);
            this.tabControl_Compras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Compras.Location = new System.Drawing.Point(0, 66);
            this.tabControl_Compras.Name = "tabControl_Compras";
            this.tabControl_Compras.SelectedIndex = 0;
            this.tabControl_Compras.Size = new System.Drawing.Size(1283, 616);
            this.tabControl_Compras.TabIndex = 0;
            // 
            // tabPage_NF
            // 
            this.tabPage_NF.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_NF.Controls.Add(this.dtvwComprasNF);
            this.tabPage_NF.Controls.Add(this.btnCancelar);
            this.tabPage_NF.Controls.Add(this.pnCamposNF);
            this.tabPage_NF.Controls.Add(this.btnProximo);
            this.tabPage_NF.Controls.Add(this.pnCamposItens);
            this.tabPage_NF.Controls.Add(this.lbl_Linha2);
            this.tabPage_NF.Controls.Add(this.lbl_Linha1);
            this.tabPage_NF.Controls.Add(this.btnEnviar);
            this.tabPage_NF.Controls.Add(this.txtVlrTtl);
            this.tabPage_NF.Controls.Add(this.lbl_VlrTtl);
            this.tabPage_NF.Location = new System.Drawing.Point(4, 29);
            this.tabPage_NF.Name = "tabPage_NF";
            this.tabPage_NF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NF.Size = new System.Drawing.Size(1275, 583);
            this.tabPage_NF.TabIndex = 0;
            this.tabPage_NF.Text = "Receber Nota Fiscal";
            // 
            // dtvwComprasNF
            // 
            this.dtvwComprasNF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtvwComprasNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvwComprasNF.Location = new System.Drawing.Point(817, 6);
            this.dtvwComprasNF.Name = "dtvwComprasNF";
            this.dtvwComprasNF.RowHeadersWidth = 62;
            this.dtvwComprasNF.Size = new System.Drawing.Size(485, 572);
            this.dtvwComprasNF.TabIndex = 50;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(294, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 41);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnCamposNF
            // 
            this.pnCamposNF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnCamposNF.AutoScroll = true;
            this.pnCamposNF.Controls.Add(this.lbl_CodFornecedor);
            this.pnCamposNF.Controls.Add(this.txtCodFornecedor);
            this.pnCamposNF.Controls.Add(this.lbl_CodNF);
            this.pnCamposNF.Controls.Add(this.txtCodNF);
            this.pnCamposNF.Controls.Add(this.lbl_DataEmissao);
            this.pnCamposNF.Controls.Add(this.dateEmissao);
            this.pnCamposNF.Location = new System.Drawing.Point(-10, 19);
            this.pnCamposNF.Name = "pnCamposNF";
            this.pnCamposNF.Size = new System.Drawing.Size(787, 100);
            this.pnCamposNF.TabIndex = 49;
            // 
            // lbl_CodFornecedor
            // 
            this.lbl_CodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CodFornecedor.AutoSize = true;
            this.lbl_CodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodFornecedor.Location = new System.Drawing.Point(15, 15);
            this.lbl_CodFornecedor.Name = "lbl_CodFornecedor";
            this.lbl_CodFornecedor.Size = new System.Drawing.Size(253, 25);
            this.lbl_CodFornecedor.TabIndex = 12;
            this.lbl_CodFornecedor.Text = "Código do Fornecedor:";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.Location = new System.Drawing.Point(21, 49);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(237, 26);
            this.txtCodFornecedor.TabIndex = 13;
            // 
            // lbl_CodNF
            // 
            this.lbl_CodNF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CodNF.AutoSize = true;
            this.lbl_CodNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodNF.Location = new System.Drawing.Point(298, 15);
            this.lbl_CodNF.Name = "lbl_CodNF";
            this.lbl_CodNF.Size = new System.Drawing.Size(252, 25);
            this.lbl_CodNF.TabIndex = 27;
            this.lbl_CodNF.Text = "Código da Nota Fiscal:";
            // 
            // txtCodNF
            // 
            this.txtCodNF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodNF.Location = new System.Drawing.Point(304, 49);
            this.txtCodNF.Name = "txtCodNF";
            this.txtCodNF.Size = new System.Drawing.Size(225, 26);
            this.txtCodNF.TabIndex = 28;
            // 
            // lbl_DataEmissao
            // 
            this.lbl_DataEmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataEmissao.AutoSize = true;
            this.lbl_DataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_DataEmissao.Location = new System.Drawing.Point(570, 15);
            this.lbl_DataEmissao.Name = "lbl_DataEmissao";
            this.lbl_DataEmissao.Size = new System.Drawing.Size(197, 25);
            this.lbl_DataEmissao.TabIndex = 17;
            this.lbl_DataEmissao.Text = "Data de Emissão:";
            // 
            // dateEmissao
            // 
            this.dateEmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEmissao.Enabled = false;
            this.dateEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmissao.Location = new System.Drawing.Point(586, 49);
            this.dateEmissao.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateEmissao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateEmissao.Name = "dateEmissao";
            this.dateEmissao.Size = new System.Drawing.Size(140, 29);
            this.dateEmissao.TabIndex = 16;
            this.dateEmissao.Value = new System.DateTime(2025, 11, 26, 0, 0, 0, 0);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProximo.Location = new System.Drawing.Point(306, 142);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(119, 31);
            this.btnProximo.TabIndex = 47;
            this.btnProximo.TabStop = false;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // pnCamposItens
            // 
            this.pnCamposItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnCamposItens.AutoScroll = true;
            this.pnCamposItens.Controls.Add(this.btnAdd);
            this.pnCamposItens.Controls.Add(this.lbl_NomeProduto);
            this.pnCamposItens.Controls.Add(this.numQtd);
            this.pnCamposItens.Controls.Add(this.lbl_Qtd);
            this.pnCamposItens.Controls.Add(this.label7);
            this.pnCamposItens.Controls.Add(this.numQtdACad);
            this.pnCamposItens.Controls.Add(this.label4);
            this.pnCamposItens.Controls.Add(this.cmbTipoUnitario);
            this.pnCamposItens.Controls.Add(this.dateValidade);
            this.pnCamposItens.Controls.Add(this.lbl_DataVldd);
            this.pnCamposItens.Controls.Add(this.lbl_Preco);
            this.pnCamposItens.Controls.Add(this.txtPreco);
            this.pnCamposItens.Controls.Add(this.txtTipoProduto);
            this.pnCamposItens.Controls.Add(this.txtNomeProduto);
            this.pnCamposItens.Controls.Add(this.lbl_TipoProduto);
            this.pnCamposItens.Controls.Add(this.lbl_Lote);
            this.pnCamposItens.Controls.Add(this.txtLote);
            this.pnCamposItens.Controls.Add(this.lbl_CodBarras);
            this.pnCamposItens.Controls.Add(this.txtCodBarras);
            this.pnCamposItens.Location = new System.Drawing.Point(-10, 225);
            this.pnCamposItens.Name = "pnCamposItens";
            this.pnCamposItens.Size = new System.Drawing.Size(812, 272);
            this.pnCamposItens.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(659, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 31);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.AutoSize = true;
            this.lbl_NomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_NomeProduto.Location = new System.Drawing.Point(45, 21);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(168, 25);
            this.lbl_NomeProduto.TabIndex = 29;
            this.lbl_NomeProduto.Text = "Nome Produto:";
            // 
            // numQtd
            // 
            this.numQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd.Location = new System.Drawing.Point(530, 52);
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(77, 29);
            this.numQtd.TabIndex = 2;
            // 
            // lbl_Qtd
            // 
            this.lbl_Qtd.AutoSize = true;
            this.lbl_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Qtd.Location = new System.Drawing.Point(525, 21);
            this.lbl_Qtd.Name = "lbl_Qtd";
            this.lbl_Qtd.Size = new System.Drawing.Size(56, 25);
            this.lbl_Qtd.TabIndex = 3;
            this.lbl_Qtd.Text = "Qtd:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(414, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade de Produtos:";
            // 
            // numQtdACad
            // 
            this.numQtdACad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQtdACad.Location = new System.Drawing.Point(458, 100);
            this.numQtdACad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdACad.Name = "numQtdACad";
            this.numQtdACad.Size = new System.Drawing.Size(179, 26);
            this.numQtdACad.TabIndex = 37;
            this.numQtdACad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdACad.ValueChanged += new System.EventHandler(this.numQtdACad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tipo Unitario:";
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
            this.cmbTipoUnitario.Location = new System.Drawing.Point(51, 181);
            this.cmbTipoUnitario.Name = "cmbTipoUnitario";
            this.cmbTipoUnitario.Size = new System.Drawing.Size(239, 28);
            this.cmbTipoUnitario.TabIndex = 35;
            // 
            // dateValidade
            // 
            this.dateValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateValidade.Location = new System.Drawing.Point(649, 53);
            this.dateValidade.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.dateValidade.Name = "dateValidade";
            this.dateValidade.Size = new System.Drawing.Size(139, 29);
            this.dateValidade.TabIndex = 6;
            // 
            // lbl_DataVldd
            // 
            this.lbl_DataVldd.AutoSize = true;
            this.lbl_DataVldd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataVldd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_DataVldd.Location = new System.Drawing.Point(617, 21);
            this.lbl_DataVldd.Name = "lbl_DataVldd";
            this.lbl_DataVldd.Size = new System.Drawing.Size(200, 25);
            this.lbl_DataVldd.TabIndex = 7;
            this.lbl_DataVldd.Text = "Data de Validade:";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Preco.Location = new System.Drawing.Point(283, 84);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(80, 25);
            this.lbl_Preco.TabIndex = 8;
            this.lbl_Preco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(289, 118);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(120, 26);
            this.txtPreco.TabIndex = 9;
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Location = new System.Drawing.Point(52, 118);
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(194, 26);
            this.txtTipoProduto.TabIndex = 32;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(51, 55);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(237, 26);
            this.txtNomeProduto.TabIndex = 30;
            // 
            // lbl_TipoProduto
            // 
            this.lbl_TipoProduto.AutoSize = true;
            this.lbl_TipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_TipoProduto.Location = new System.Drawing.Point(46, 84);
            this.lbl_TipoProduto.Name = "lbl_TipoProduto";
            this.lbl_TipoProduto.Size = new System.Drawing.Size(187, 25);
            this.lbl_TipoProduto.TabIndex = 31;
            this.lbl_TipoProduto.Text = "Tipo de Produto:";
            // 
            // lbl_Lote
            // 
            this.lbl_Lote.AutoSize = true;
            this.lbl_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_Lote.Location = new System.Drawing.Point(311, 147);
            this.lbl_Lote.Name = "lbl_Lote";
            this.lbl_Lote.Size = new System.Drawing.Size(65, 25);
            this.lbl_Lote.TabIndex = 4;
            this.lbl_Lote.Text = "Lote:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(317, 181);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(290, 26);
            this.txtLote.TabIndex = 5;
            // 
            // lbl_CodBarras
            // 
            this.lbl_CodBarras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CodBarras.AutoSize = true;
            this.lbl_CodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_CodBarras.Location = new System.Drawing.Point(303, 3);
            this.lbl_CodBarras.Name = "lbl_CodBarras";
            this.lbl_CodBarras.Size = new System.Drawing.Size(209, 25);
            this.lbl_CodBarras.TabIndex = 0;
            this.lbl_CodBarras.Text = "Código de Barras: ";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodBarras.Location = new System.Drawing.Point(308, 37);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(196, 26);
            this.txtCodBarras.TabIndex = 1;
            // 
            // lbl_Linha2
            // 
            this.lbl_Linha2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Linha2.AutoSize = true;
            this.lbl_Linha2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Linha2.Location = new System.Drawing.Point(-27, 580);
            this.lbl_Linha2.Name = "lbl_Linha2";
            this.lbl_Linha2.Size = new System.Drawing.Size(829, 20);
            this.lbl_Linha2.TabIndex = 45;
            this.lbl_Linha2.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // lbl_Linha1
            // 
            this.lbl_Linha1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Linha1.AutoSize = true;
            this.lbl_Linha1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Linha1.Location = new System.Drawing.Point(-27, 178);
            this.lbl_Linha1.Name = "lbl_Linha1";
            this.lbl_Linha1.Size = new System.Drawing.Size(829, 20);
            this.lbl_Linha1.TabIndex = 44;
            this.lbl_Linha1.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.Location = new System.Drawing.Point(422, 530);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(122, 41);
            this.btnEnviar.TabIndex = 43;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // txtVlrTtl
            // 
            this.txtVlrTtl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVlrTtl.Location = new System.Drawing.Point(45, 540);
            this.txtVlrTtl.Name = "txtVlrTtl";
            this.txtVlrTtl.Size = new System.Drawing.Size(237, 26);
            this.txtVlrTtl.TabIndex = 11;
            // 
            // lbl_VlrTtl
            // 
            this.lbl_VlrTtl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_VlrTtl.AutoSize = true;
            this.lbl_VlrTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VlrTtl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_VlrTtl.Location = new System.Drawing.Point(39, 512);
            this.lbl_VlrTtl.Name = "lbl_VlrTtl";
            this.lbl_VlrTtl.Size = new System.Drawing.Size(134, 25);
            this.lbl_VlrTtl.TabIndex = 10;
            this.lbl_VlrTtl.Text = "Valor Total:";
            // 
            // tabPage_Divida
            // 
            this.tabPage_Divida.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_Divida.Controls.Add(this.btnPagar);
            this.tabPage_Divida.Controls.Add(this.label5);
            this.tabPage_Divida.Controls.Add(this.dataGridView1);
            this.tabPage_Divida.Controls.Add(this.btnBuscar);
            this.tabPage_Divida.Controls.Add(this.cmbFiltro);
            this.tabPage_Divida.Controls.Add(this.txtFiltro);
            this.tabPage_Divida.Controls.Add(this.label2);
            this.tabPage_Divida.Controls.Add(this.lbl_Data2);
            this.tabPage_Divida.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Divida.Name = "tabPage_Divida";
            this.tabPage_Divida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Divida.Size = new System.Drawing.Size(1275, 583);
            this.tabPage_Divida.TabIndex = 1;
            this.tabPage_Divida.Text = "Dívidas";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(817, 59);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(99, 30);
            this.btnPagar.TabIndex = 33;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(383, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Filtro:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1,
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1,
            this.oBSERVACAODataGridViewTextBoxColumn1,
            this.dATAEMISSAODataGridViewTextBoxColumn1,
            this.vALORCOMPRADataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.compraDividasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 455);
            this.dataGridView1.TabIndex = 31;
            // 
            // iDNOTAFISCALFORNECDataGridViewTextBoxColumn1
            // 
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.DataPropertyName = "ID_NOTA_FISCAL_FORNEC";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.HeaderText = "ID NF";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.Name = "iDNOTAFISCALFORNECDataGridViewTextBoxColumn1";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nOMEFORNECEDORDataGridViewTextBoxColumn1
            // 
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1.DataPropertyName = "NOME_FORNECEDOR";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1.HeaderText = "NOME DO FORNECEDOR";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1.Name = "nOMEFORNECEDORDataGridViewTextBoxColumn1";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn1.Width = 300;
            // 
            // oBSERVACAODataGridViewTextBoxColumn1
            // 
            this.oBSERVACAODataGridViewTextBoxColumn1.DataPropertyName = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn1.HeaderText = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.oBSERVACAODataGridViewTextBoxColumn1.Name = "oBSERVACAODataGridViewTextBoxColumn1";
            this.oBSERVACAODataGridViewTextBoxColumn1.Width = 300;
            // 
            // dATAEMISSAODataGridViewTextBoxColumn1
            // 
            this.dATAEMISSAODataGridViewTextBoxColumn1.DataPropertyName = "DATA_EMISSAO";
            this.dATAEMISSAODataGridViewTextBoxColumn1.HeaderText = "DATA DE EMISSAO";
            this.dATAEMISSAODataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dATAEMISSAODataGridViewTextBoxColumn1.Name = "dATAEMISSAODataGridViewTextBoxColumn1";
            this.dATAEMISSAODataGridViewTextBoxColumn1.Width = 200;
            // 
            // vALORCOMPRADataGridViewTextBoxColumn1
            // 
            this.vALORCOMPRADataGridViewTextBoxColumn1.DataPropertyName = "VALOR_COMPRA";
            this.vALORCOMPRADataGridViewTextBoxColumn1.HeaderText = "VALOR";
            this.vALORCOMPRADataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.vALORCOMPRADataGridViewTextBoxColumn1.Name = "vALORCOMPRADataGridViewTextBoxColumn1";
            this.vALORCOMPRADataGridViewTextBoxColumn1.Width = 200;
            // 
            // compraDividasBindingSource
            // 
            this.compraDividasBindingSource.DataMember = "compraDividas";
            this.compraDividasBindingSource.DataSource = this.daDadosEntrada;
            // 
            // daDadosEntrada
            // 
            this.daDadosEntrada.DataSetName = "daDadosEntrada";
            this.daDadosEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(689, 59);
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
            this.cmbFiltro.Location = new System.Drawing.Point(57, 59);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(302, 32);
            this.cmbFiltro.TabIndex = 28;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtFiltro.Location = new System.Drawing.Point(388, 59);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(263, 31);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(52, 21);
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
            this.tabPage_CompraAntg.Controls.Add(this.label6);
            this.tabPage_CompraAntg.Controls.Add(this.btnBuscarAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.cmbFiltroAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.txtFiltroAntigas);
            this.tabPage_CompraAntg.Controls.Add(this.label3);
            this.tabPage_CompraAntg.Controls.Add(this.dataGridView2);
            this.tabPage_CompraAntg.Controls.Add(this.lbl_Data);
            this.tabPage_CompraAntg.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CompraAntg.Name = "tabPage_CompraAntg";
            this.tabPage_CompraAntg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CompraAntg.Size = new System.Drawing.Size(1275, 583);
            this.tabPage_CompraAntg.TabIndex = 2;
            this.tabPage_CompraAntg.Text = "Compras antigas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(380, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Filtro:";
            // 
            // btnBuscarAntigas
            // 
            this.btnBuscarAntigas.Location = new System.Drawing.Point(682, 58);
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
            this.cmbFiltroAntigas.Location = new System.Drawing.Point(58, 58);
            this.cmbFiltroAntigas.Name = "cmbFiltroAntigas";
            this.cmbFiltroAntigas.Size = new System.Drawing.Size(300, 32);
            this.cmbFiltroAntigas.TabIndex = 35;
            // 
            // txtFiltroAntigas
            // 
            this.txtFiltroAntigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAntigas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtFiltroAntigas.Location = new System.Drawing.Point(385, 58);
            this.txtFiltroAntigas.Multiline = true;
            this.txtFiltroAntigas.Name = "txtFiltroAntigas";
            this.txtFiltroAntigas.Size = new System.Drawing.Size(263, 31);
            this.txtFiltroAntigas.TabIndex = 34;
            this.txtFiltroAntigas.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(53, 22);
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
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn,
            this.nOMEFORNECEDORDataGridViewTextBoxColumn,
            this.oBSERVACAODataGridViewTextBoxColumn,
            this.dATAEMISSAODataGridViewTextBoxColumn,
            this.vALORCOMPRADataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.comprasAntigasBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1085, 461);
            this.dataGridView2.TabIndex = 32;
            // 
            // iDNOTAFISCALFORNECDataGridViewTextBoxColumn
            // 
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.DataPropertyName = "ID_NOTA_FISCAL_FORNEC";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.HeaderText = "ID DA NF";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.Name = "iDNOTAFISCALFORNECDataGridViewTextBoxColumn";
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNOTAFISCALFORNECDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMEFORNECEDORDataGridViewTextBoxColumn
            // 
            this.nOMEFORNECEDORDataGridViewTextBoxColumn.DataPropertyName = "NOME_FORNECEDOR";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn.HeaderText = "NOME DO FORNECEDOR";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nOMEFORNECEDORDataGridViewTextBoxColumn.Name = "nOMEFORNECEDORDataGridViewTextBoxColumn";
            this.nOMEFORNECEDORDataGridViewTextBoxColumn.Width = 300;
            // 
            // oBSERVACAODataGridViewTextBoxColumn
            // 
            this.oBSERVACAODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn.HeaderText = "OBSERVACAO";
            this.oBSERVACAODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oBSERVACAODataGridViewTextBoxColumn.Name = "oBSERVACAODataGridViewTextBoxColumn";
            this.oBSERVACAODataGridViewTextBoxColumn.Width = 300;
            // 
            // dATAEMISSAODataGridViewTextBoxColumn
            // 
            this.dATAEMISSAODataGridViewTextBoxColumn.DataPropertyName = "DATA_EMISSAO";
            this.dATAEMISSAODataGridViewTextBoxColumn.HeaderText = "DATA DE EMISSAO";
            this.dATAEMISSAODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dATAEMISSAODataGridViewTextBoxColumn.Name = "dATAEMISSAODataGridViewTextBoxColumn";
            this.dATAEMISSAODataGridViewTextBoxColumn.Width = 200;
            // 
            // vALORCOMPRADataGridViewTextBoxColumn
            // 
            this.vALORCOMPRADataGridViewTextBoxColumn.DataPropertyName = "VALOR_COMPRA";
            this.vALORCOMPRADataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORCOMPRADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vALORCOMPRADataGridViewTextBoxColumn.Name = "vALORCOMPRADataGridViewTextBoxColumn";
            this.vALORCOMPRADataGridViewTextBoxColumn.Width = 200;
            // 
            // comprasAntigasBindingSource
            // 
            this.comprasAntigasBindingSource.DataMember = "comprasAntigas";
            this.comprasAntigasBindingSource.DataSource = this.daDadosEntrada;
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
            // nOTA_FISCAL_FORNECEDORTableAdapter
            // 
            this.nOTA_FISCAL_FORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // comprasAntigasTableAdapter
            // 
            this.comprasAntigasTableAdapter.ClearBeforeFill = true;
            // 
            // compraDividasTableAdapter
            // 
            this.compraDividasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1283, 682);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvwComprasNF)).EndInit();
            this.pnCamposNF.ResumeLayout(false);
            this.pnCamposNF.PerformLayout();
            this.pnCamposItens.ResumeLayout(false);
            this.pnCamposItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdACad)).EndInit();
            this.tabPage_Divida.ResumeLayout(false);
            this.tabPage_Divida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDividasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDadosEntrada)).EndInit();
            this.tabPage_CompraAntg.ResumeLayout(false);
            this.tabPage_CompraAntg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasAntigasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALFORNECEDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Compras;
        private System.Windows.Forms.TabPage tabPage_NF;
        private System.Windows.Forms.TabPage tabPage_Divida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_CompraAntg;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Data2;
        private Dados.daDadosEntrada daDadosEntrada;
        private System.Windows.Forms.BindingSource nOTAFISCALFORNECEDORBindingSource;
        private Dados.daDadosEntradaTableAdapters.NOTA_FISCAL_FORNECEDORTableAdapter nOTA_FISCAL_FORNECEDORTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarAntigas;
        private System.Windows.Forms.ComboBox cmbFiltroAntigas;
        private System.Windows.Forms.TextBox txtFiltroAntigas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource comprasAntigasBindingSource;
        private Dados.daDadosEntradaTableAdapters.comprasAntigasTableAdapter comprasAntigasTableAdapter;
        private System.Windows.Forms.BindingSource compraDividasBindingSource;
        private Dados.daDadosEntradaTableAdapters.compraDividasTableAdapter compraDividasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNOTAFISCALFORNECDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFORNECEDORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCOMPRADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNOTAFISCALFORNECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFORNECEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAEMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtvwComprasNF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnCamposNF;
        private System.Windows.Forms.Label lbl_CodFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lbl_CodNF;
        private System.Windows.Forms.TextBox txtCodNF;
        private System.Windows.Forms.Label lbl_DataEmissao;
        private System.Windows.Forms.DateTimePicker dateEmissao;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Panel pnCamposItens;
        private System.Windows.Forms.Label lbl_NomeProduto;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.Label lbl_Qtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQtdACad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoUnitario;
        private System.Windows.Forms.DateTimePicker dateValidade;
        private System.Windows.Forms.Label lbl_DataVldd;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.TextBox txtVlrTtl;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lbl_VlrTtl;
        private System.Windows.Forms.Label lbl_TipoProduto;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lbl_CodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lbl_Linha2;
        private System.Windows.Forms.Label lbl_Linha1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPagar;
    }
}