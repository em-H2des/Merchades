namespace Merchades
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.mETODOPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosSaida = new prjMerchades.Dados.dsDadosSaida();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.numEstoqueAddProduto = new System.Windows.Forms.NumericUpDown();
            this.lblTrocoVenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnCancelaOperacao = new System.Windows.Forms.Button();
            this.btnConfirmaCompra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mETODO_PAGAMENTOTableAdapter = new prjMerchades.Dados.dsDadosSaidaTableAdapters.METODO_PAGAMENTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOPAGAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueAddProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbFormaPagamento.DataSource = this.mETODOPAGAMENTOBindingSource;
            this.cmbFormaPagamento.DisplayMember = "DESCRICAO";
            this.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(566, 147);
            this.cmbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(346, 29);
            this.cmbFormaPagamento.TabIndex = 22;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            // 
            // mETODOPAGAMENTOBindingSource
            // 
            this.mETODOPAGAMENTOBindingSource.DataMember = "METODO_PAGAMENTO";
            this.mETODOPAGAMENTOBindingSource.DataSource = this.dsDadosSaida;
            // 
            // dsDadosSaida
            // 
            this.dsDadosSaida.DataSetName = "dsDadosSaida";
            this.dsDadosSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtValorPago);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblParcelas);
            this.groupBox1.Controls.Add(this.numEstoqueAddProduto);
            this.groupBox1.Controls.Add(this.lblTrocoVenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btnCancelaOperacao);
            this.groupBox1.Controls.Add(this.cmbFormaPagamento);
            this.groupBox1.Controls.Add(this.btnConfirmaCompra);
            this.groupBox1.Location = new System.Drawing.Point(0, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(1120, 490);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtValorPago.Location = new System.Drawing.Point(211, 318);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(162, 41);
            this.txtValorPago.TabIndex = 44;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblValorTotal.Location = new System.Drawing.Point(498, 315);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(142, 40);
            this.lblValorTotal.TabIndex = 43;
            this.lblValorTotal.Text = "R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(411, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 40);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParcelas
            // 
            this.lblParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParcelas.BackColor = System.Drawing.SystemColors.Window;
            this.lblParcelas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblParcelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblParcelas.Location = new System.Drawing.Point(311, 187);
            this.lblParcelas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(213, 40);
            this.lblParcelas.TabIndex = 41;
            this.lblParcelas.Text = "Parcelas";
            this.lblParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblParcelas.Visible = false;
            // 
            // numEstoqueAddProduto
            // 
            this.numEstoqueAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numEstoqueAddProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.numEstoqueAddProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numEstoqueAddProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.numEstoqueAddProduto.ForeColor = System.Drawing.Color.White;
            this.numEstoqueAddProduto.Location = new System.Drawing.Point(565, 196);
            this.numEstoqueAddProduto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numEstoqueAddProduto.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numEstoqueAddProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEstoqueAddProduto.Name = "numEstoqueAddProduto";
            this.numEstoqueAddProduto.Size = new System.Drawing.Size(345, 31);
            this.numEstoqueAddProduto.TabIndex = 40;
            this.numEstoqueAddProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEstoqueAddProduto.Visible = false;
            // 
            // lblTrocoVenda
            // 
            this.lblTrocoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrocoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.lblTrocoVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblTrocoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblTrocoVenda.Location = new System.Drawing.Point(717, 315);
            this.lblTrocoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrocoVenda.Name = "lblTrocoVenda";
            this.lblTrocoVenda.Size = new System.Drawing.Size(233, 40);
            this.lblTrocoVenda.TabIndex = 39;
            this.lblTrocoVenda.Text = "R$ 0,00";
            this.lblTrocoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(700, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 40);
            this.label4.TabIndex = 37;
            this.label4.Text = "Troco:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1115, 90);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tela de Pagamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(68, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 40);
            this.label2.TabIndex = 35;
            this.label2.Text = "Valor Pago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label.Location = new System.Drawing.Point(154, 135);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(391, 40);
            this.label.TabIndex = 33;
            this.label.Text = "Forma de Pagamento:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelaOperacao
            // 
            this.btnCancelaOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelaOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnCancelaOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaOperacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnCancelaOperacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaOperacao.Location = new System.Drawing.Point(211, 420);
            this.btnCancelaOperacao.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancelaOperacao.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnCancelaOperacao.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnCancelaOperacao.Name = "btnCancelaOperacao";
            this.btnCancelaOperacao.Size = new System.Drawing.Size(283, 51);
            this.btnCancelaOperacao.TabIndex = 30;
            this.btnCancelaOperacao.Text = "Cancelar Operação";
            this.btnCancelaOperacao.UseVisualStyleBackColor = false;
            this.btnCancelaOperacao.Click += new System.EventHandler(this.btnCancelaOperacao_Click);
            // 
            // btnConfirmaCompra
            // 
            this.btnConfirmaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(213)))), ((int)(((byte)(134)))));
            this.btnConfirmaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnConfirmaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmaCompra.Location = new System.Drawing.Point(588, 420);
            this.btnConfirmaCompra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmaCompra.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnConfirmaCompra.Name = "btnConfirmaCompra";
            this.btnConfirmaCompra.Size = new System.Drawing.Size(283, 51);
            this.btnConfirmaCompra.TabIndex = 29;
            this.btnConfirmaCompra.Text = "Confirmar Pagamento\r\n";
            this.btnConfirmaCompra.UseVisualStyleBackColor = false;
            this.btnConfirmaCompra.Click += new System.EventHandler(this.btnConfirmaCompra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades;
            this.pictureBox1.Location = new System.Drawing.Point(162, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1120, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // mETODO_PAGAMENTOTableAdapter
            // 
            this.mETODO_PAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1120, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmPagamento";
            this.Text = "Tela de Pagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mETODOPAGAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosSaida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueAddProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmaCompra;
        private System.Windows.Forms.Button btnCancelaOperacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTrocoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown numEstoqueAddProduto;
        private prjMerchades.Dados.dsDadosSaida dsDadosSaida;
        private System.Windows.Forms.BindingSource mETODOPAGAMENTOBindingSource;
        private prjMerchades.Dados.dsDadosSaidaTableAdapters.METODO_PAGAMENTOTableAdapter mETODO_PAGAMENTOTableAdapter;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
    }
}