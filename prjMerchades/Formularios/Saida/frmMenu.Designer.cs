namespace Merchades
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tabControlSaida = new System.Windows.Forms.TabControl();
            this.tabCaixa = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDiminuiQtd = new System.Windows.Forms.Button();
            this.btnAumentaQtd = new System.Windows.Forms.Button();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizaCompra = new System.Windows.Forms.Button();
            this.btnCancelaVenda = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.dataGridViewProdutosCarrinho = new System.Windows.Forms.DataGridView();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.txtBuscarEstoque = new System.Windows.Forms.TextBox();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnAddItemCarrinho = new System.Windows.Forms.Button();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridViewProdutosDisponiveis = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resumoEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosSaida = new prjMerchades.Dados.dsDadosSaida();
            this.resumoEstoqueTableAdapter = new prjMerchades.Dados.dsDadosSaidaTableAdapters.ResumoEstoqueTableAdapter();
            this.cODIGODEBARRASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodFiscal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.tabControlSaida.SuspendLayout();
            this.tabCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).BeginInit();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSaida
            // 
            this.tabControlSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSaida.Controls.Add(this.tabCaixa);
            this.tabControlSaida.Controls.Add(this.tabProdutos);
            this.tabControlSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.tabControlSaida.HotTrack = true;
            this.tabControlSaida.Location = new System.Drawing.Point(0, 46);
            this.tabControlSaida.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlSaida.Name = "tabControlSaida";
            this.tabControlSaida.SelectedIndex = 0;
            this.tabControlSaida.Size = new System.Drawing.Size(1022, 493);
            this.tabControlSaida.TabIndex = 0;
            // 
            // tabCaixa
            // 
            this.tabCaixa.Controls.Add(this.txtCpf);
            this.tabCaixa.Controls.Add(this.label8);
            this.tabCaixa.Controls.Add(this.lblCodFiscal);
            this.tabCaixa.Controls.Add(this.label7);
            this.tabCaixa.Controls.Add(this.btnDiminuiQtd);
            this.tabCaixa.Controls.Add(this.btnAumentaQtd);
            this.tabCaixa.Controls.Add(this.lblTotalFinal);
            this.tabCaixa.Controls.Add(this.label6);
            this.tabCaixa.Controls.Add(this.label4);
            this.tabCaixa.Controls.Add(this.btnFinalizaCompra);
            this.tabCaixa.Controls.Add(this.btnCancelaVenda);
            this.tabCaixa.Controls.Add(this.btnExcluirItem);
            this.tabCaixa.Controls.Add(this.btnAdicionarItem);
            this.tabCaixa.Controls.Add(this.dataGridViewProdutosCarrinho);
            this.tabCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabCaixa.Location = new System.Drawing.Point(4, 48);
            this.tabCaixa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabCaixa.Name = "tabCaixa";
            this.tabCaixa.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabCaixa.Size = new System.Drawing.Size(1014, 441);
            this.tabCaixa.TabIndex = 0;
            this.tabCaixa.Text = "Caixa";
            this.tabCaixa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label7.Location = new System.Drawing.Point(222, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "Alterar Quantidade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiminuiQtd
            // 
            this.btnDiminuiQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiminuiQtd.AutoSize = true;
            this.btnDiminuiQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnDiminuiQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuiQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnDiminuiQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiminuiQtd.Location = new System.Drawing.Point(229, 397);
            this.btnDiminuiQtd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDiminuiQtd.Name = "btnDiminuiQtd";
            this.btnDiminuiQtd.Size = new System.Drawing.Size(142, 34);
            this.btnDiminuiQtd.TabIndex = 58;
            this.btnDiminuiQtd.Text = "▼";
            this.btnDiminuiQtd.UseVisualStyleBackColor = false;
            this.btnDiminuiQtd.Click += new System.EventHandler(this.btnDiminuiQtd_Click);
            // 
            // btnAumentaQtd
            // 
            this.btnAumentaQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAumentaQtd.AutoSize = true;
            this.btnAumentaQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAumentaQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentaQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAumentaQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAumentaQtd.Location = new System.Drawing.Point(229, 337);
            this.btnAumentaQtd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAumentaQtd.Name = "btnAumentaQtd";
            this.btnAumentaQtd.Size = new System.Drawing.Size(142, 34);
            this.btnAumentaQtd.TabIndex = 57;
            this.btnAumentaQtd.Text = "▲";
            this.btnAumentaQtd.UseVisualStyleBackColor = false;
            this.btnAumentaQtd.Click += new System.EventHandler(this.btnAumentaQtd_Click);
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.8F);
            this.lblTotalFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblTotalFinal.Location = new System.Drawing.Point(825, 148);
            this.lblTotalFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(121, 36);
            this.lblTotalFinal.TabIndex = 56;
            this.lblTotalFinal.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(665, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Total Final:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(435, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 39);
            this.label4.TabIndex = 49;
            this.label4.Text = "CPF:";
            // 
            // btnFinalizaCompra
            // 
            this.btnFinalizaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnFinalizaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnFinalizaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizaCompra.Location = new System.Drawing.Point(684, 359);
            this.btnFinalizaCompra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFinalizaCompra.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnFinalizaCompra.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnFinalizaCompra.Name = "btnFinalizaCompra";
            this.btnFinalizaCompra.Size = new System.Drawing.Size(262, 51);
            this.btnFinalizaCompra.TabIndex = 48;
            this.btnFinalizaCompra.Text = "Finalizar Venda ⇉";
            this.btnFinalizaCompra.UseVisualStyleBackColor = false;
            this.btnFinalizaCompra.Click += new System.EventHandler(this.btnFinalizaCompra_Click);
            // 
            // btnCancelaVenda
            // 
            this.btnCancelaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnCancelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnCancelaVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaVenda.Location = new System.Drawing.Point(684, 285);
            this.btnCancelaVenda.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancelaVenda.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnCancelaVenda.MinimumSize = new System.Drawing.Size(139, 39);
            this.btnCancelaVenda.Name = "btnCancelaVenda";
            this.btnCancelaVenda.Size = new System.Drawing.Size(262, 51);
            this.btnCancelaVenda.TabIndex = 41;
            this.btnCancelaVenda.Text = "⇇ Cancelar Venda";
            this.btnCancelaVenda.UseVisualStyleBackColor = false;
            this.btnCancelaVenda.Click += new System.EventHandler(this.btnCancelaVenda_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnExcluirItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirItem.Location = new System.Drawing.Point(442, 365);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExcluirItem.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnExcluirItem.MinimumSize = new System.Drawing.Size(112, 29);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(172, 42);
            this.btnExcluirItem.TabIndex = 39;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAdicionarItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarItem.Location = new System.Drawing.Point(17, 365);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAdicionarItem.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnAdicionarItem.MinimumSize = new System.Drawing.Size(112, 29);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(172, 42);
            this.btnAdicionarItem.TabIndex = 38;
            this.btnAdicionarItem.Text = "+ Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // dataGridViewProdutosCarrinho
            // 
            this.dataGridViewProdutosCarrinho.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDesc,
            this.ColumnQtd,
            this.ColumnValUni,
            this.ColumnTotal});
            this.dataGridViewProdutosCarrinho.Location = new System.Drawing.Point(17, 84);
            this.dataGridViewProdutosCarrinho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewProdutosCarrinho.MinimumSize = new System.Drawing.Size(439, 110);
            this.dataGridViewProdutosCarrinho.Name = "dataGridViewProdutosCarrinho";
            this.dataGridViewProdutosCarrinho.ReadOnly = true;
            this.dataGridViewProdutosCarrinho.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinho.RowTemplate.Height = 28;
            this.dataGridViewProdutosCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutosCarrinho.Size = new System.Drawing.Size(558, 240);
            this.dataGridViewProdutosCarrinho.TabIndex = 37;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.btnLimparFiltro);
            this.tabProdutos.Controls.Add(this.txtBuscarEstoque);
            this.tabProdutos.Controls.Add(this.btnVoltarTelaInicial);
            this.tabProdutos.Controls.Add(this.label3);
            this.tabProdutos.Controls.Add(this.label2);
            this.tabProdutos.Controls.Add(this.label1);
            this.tabProdutos.Controls.Add(this.btnAplicar);
            this.tabProdutos.Controls.Add(this.btnAddItemCarrinho);
            this.tabProdutos.Controls.Add(this.cmbOrdenar);
            this.tabProdutos.Controls.Add(this.cmbFiltro);
            this.tabProdutos.Controls.Add(this.dataGridViewProdutosDisponiveis);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabProdutos.Location = new System.Drawing.Point(4, 48);
            this.tabProdutos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabProdutos.Size = new System.Drawing.Size(1014, 441);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Estoque";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(32)))));
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnLimparFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparFiltro.Location = new System.Drawing.Point(829, 321);
            this.btnLimparFiltro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLimparFiltro.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnLimparFiltro.MinimumSize = new System.Drawing.Size(74, 27);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(157, 46);
            this.btnLimparFiltro.TabIndex = 46;
            this.btnLimparFiltro.Text = "Limpar Filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // txtBuscarEstoque
            // 
            this.txtBuscarEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.txtBuscarEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.txtBuscarEstoque.ForeColor = System.Drawing.Color.White;
            this.txtBuscarEstoque.Location = new System.Drawing.Point(640, 125);
            this.txtBuscarEstoque.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscarEstoque.Name = "txtBuscarEstoque";
            this.txtBuscarEstoque.Size = new System.Drawing.Size(346, 29);
            this.txtBuscarEstoque.TabIndex = 35;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarTelaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnVoltarTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnVoltarTelaInicial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(820, 27);
            this.btnVoltarTelaInicial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnVoltarTelaInicial.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnVoltarTelaInicial.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(190, 38);
            this.btnVoltarTelaInicial.TabIndex = 45;
            this.btnVoltarTelaInicial.Text = "↺  Voltar";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = false;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(641, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 40);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ordenar por:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(641, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filtrar por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(641, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicar.Location = new System.Drawing.Point(641, 321);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAplicar.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnAplicar.MinimumSize = new System.Drawing.Size(74, 27);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(157, 46);
            this.btnAplicar.TabIndex = 41;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnAddItemCarrinho
            // 
            this.btnAddItemCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItemCarrinho.AutoSize = true;
            this.btnAddItemCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAddItemCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAddItemCarrinho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItemCarrinho.Location = new System.Drawing.Point(687, 369);
            this.btnAddItemCarrinho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddItemCarrinho.MinimumSize = new System.Drawing.Size(74, 27);
            this.btnAddItemCarrinho.Name = "btnAddItemCarrinho";
            this.btnAddItemCarrinho.Size = new System.Drawing.Size(254, 46);
            this.btnAddItemCarrinho.TabIndex = 40;
            this.btnAddItemCarrinho.Text = "+ Adicionar à venda";
            this.btnAddItemCarrinho.UseVisualStyleBackColor = false;
            this.btnAddItemCarrinho.Click += new System.EventHandler(this.btnAddItemCarrinho_Click);
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrdenar.Font = new System.Drawing.Font("Arial", 13.8F);
            this.cmbOrdenar.ForeColor = System.Drawing.Color.White;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Unidade de Medida",
            "Categoria",
            "Estoque Atual",
            "Preço de Venda"});
            this.cmbOrdenar.Location = new System.Drawing.Point(641, 280);
            this.cmbOrdenar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(346, 29);
            this.cmbOrdenar.TabIndex = 37;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltro.Font = new System.Drawing.Font("Arial", 13.8F);
            this.cmbFiltro.ForeColor = System.Drawing.Color.White;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Unidade de Medida",
            "Categoria",
            "Estoque Atual",
            "Preço de Venda"});
            this.cmbFiltro.Location = new System.Drawing.Point(640, 196);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(346, 29);
            this.cmbFiltro.TabIndex = 36;
            // 
            // dataGridViewProdutosDisponiveis
            // 
            this.dataGridViewProdutosDisponiveis.AllowUserToAddRows = false;
            this.dataGridViewProdutosDisponiveis.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosDisponiveis.AutoGenerateColumns = false;
            this.dataGridViewProdutosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODEBARRASDataGridViewTextBoxColumn,
            this.nOMEPRODUTOSDataGridViewTextBoxColumn,
            this.tIPOUNITARIODataGridViewTextBoxColumn,
            this.tIPOPRODUTOSDataGridViewTextBoxColumn,
            this.qTDESTOQUEDataGridViewTextBoxColumn,
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn});
            this.dataGridViewProdutosDisponiveis.DataSource = this.resumoEstoqueBindingSource;
            this.dataGridViewProdutosDisponiveis.Location = new System.Drawing.Point(7, 21);
            this.dataGridViewProdutosDisponiveis.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewProdutosDisponiveis.Name = "dataGridViewProdutosDisponiveis";
            this.dataGridViewProdutosDisponiveis.ReadOnly = true;
            this.dataGridViewProdutosDisponiveis.RowHeadersWidth = 62;
            this.dataGridViewProdutosDisponiveis.RowTemplate.Height = 28;
            this.dataGridViewProdutosDisponiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutosDisponiveis.Size = new System.Drawing.Size(600, 412);
            this.dataGridViewProdutosDisponiveis.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades1;
            this.pictureBox1.Location = new System.Drawing.Point(785, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // resumoEstoqueBindingSource
            // 
            this.resumoEstoqueBindingSource.DataMember = "ResumoEstoque";
            this.resumoEstoqueBindingSource.DataSource = this.dsDadosSaida;
            // 
            // dsDadosSaida
            // 
            this.dsDadosSaida.DataSetName = "dsDadosSaida";
            this.dsDadosSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resumoEstoqueTableAdapter
            // 
            this.resumoEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // cODIGODEBARRASDataGridViewTextBoxColumn
            // 
            this.cODIGODEBARRASDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_DE_BARRAS";
            this.cODIGODEBARRASDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODIGODEBARRASDataGridViewTextBoxColumn.Name = "cODIGODEBARRASDataGridViewTextBoxColumn";
            this.cODIGODEBARRASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEPRODUTOSDataGridViewTextBoxColumn
            // 
            this.nOMEPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "NOME_PRODUTOS";
            this.nOMEPRODUTOSDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMEPRODUTOSDataGridViewTextBoxColumn.Name = "nOMEPRODUTOSDataGridViewTextBoxColumn";
            this.nOMEPRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOUNITARIODataGridViewTextBoxColumn
            // 
            this.tIPOUNITARIODataGridViewTextBoxColumn.DataPropertyName = "TIPO_UNITARIO";
            this.tIPOUNITARIODataGridViewTextBoxColumn.HeaderText = "Unidade de Medida";
            this.tIPOUNITARIODataGridViewTextBoxColumn.Name = "tIPOUNITARIODataGridViewTextBoxColumn";
            this.tIPOUNITARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOPRODUTOSDataGridViewTextBoxColumn
            // 
            this.tIPOPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "TIPO_PRODUTOS";
            this.tIPOPRODUTOSDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.tIPOPRODUTOSDataGridViewTextBoxColumn.Name = "tIPOPRODUTOSDataGridViewTextBoxColumn";
            this.tIPOPRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTDESTOQUEDataGridViewTextBoxColumn
            // 
            this.qTDESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "QTD_ESTOQUE";
            this.qTDESTOQUEDataGridViewTextBoxColumn.HeaderText = "Estoque Atual";
            this.qTDESTOQUEDataGridViewTextBoxColumn.Name = "qTDESTOQUEDataGridViewTextBoxColumn";
            this.qTDESTOQUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECO_PRODUTOSDataGridViewTextBoxColumn
            // 
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "PRECO_PRODUTOS";
            dataGridViewCellStyle3.Format = "C2";
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn.HeaderText = "Preço de Venda";
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn.Name = "pRECO_PRODUTOSDataGridViewTextBoxColumn";
            this.pRECO_PRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.HeaderText = "Produto";
            this.ColumnDesc.MinimumWidth = 8;
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Width = 150;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade";
            this.ColumnQtd.MinimumWidth = 8;
            this.ColumnQtd.Name = "ColumnQtd";
            this.ColumnQtd.ReadOnly = true;
            this.ColumnQtd.Width = 150;
            // 
            // ColumnValUni
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.ColumnValUni.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnValUni.HeaderText = "Preço Unitário";
            this.ColumnValUni.MinimumWidth = 8;
            this.ColumnValUni.Name = "ColumnValUni";
            this.ColumnValUni.ReadOnly = true;
            this.ColumnValUni.Width = 150;
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.ColumnTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.MinimumWidth = 8;
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 150;
            // 
            // lblCodFiscal
            // 
            this.lblCodFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.lblCodFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCodFiscal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodFiscal.Location = new System.Drawing.Point(185, 25);
            this.lblCodFiscal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodFiscal.Name = "lblCodFiscal";
            this.lblCodFiscal.Size = new System.Drawing.Size(131, 27);
            this.lblCodFiscal.TabIndex = 60;
            this.lblCodFiscal.Text = "1";
            this.lblCodFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 39);
            this.label8.TabIndex = 61;
            this.label8.Text = "CÓDIGO:";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCpf.Location = new System.Drawing.Point(548, 24);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(385, 28);
            this.txtCpf.TabIndex = 62;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1022, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlSaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.tabControlSaida.ResumeLayout(false);
            this.tabCaixa.ResumeLayout(false);
            this.tabCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSaida;
        private System.Windows.Forms.TabPage tabCaixa;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewProdutosCarrinho;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnCancelaVenda;
        private System.Windows.Forms.DataGridView dataGridViewProdutosDisponiveis;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnAddItemCarrinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
        private System.Windows.Forms.Button btnFinalizaCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Button btnAumentaQtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDiminuiQtd;
        private prjMerchades.Dados.dsDadosSaida dsDadosSaida;
        private System.Windows.Forms.BindingSource resumoEstoqueBindingSource;
        private prjMerchades.Dados.dsDadosSaidaTableAdapters.ResumoEstoqueTableAdapter resumoEstoqueTableAdapter;
        private System.Windows.Forms.TextBox txtBuscarEstoque;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODEBARRASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECO_PRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodFiscal;
    }
}