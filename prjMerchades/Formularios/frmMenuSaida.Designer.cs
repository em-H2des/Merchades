namespace prjMerchades.Formularios
{
    partial class frmMenuSaida
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
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.btnVercompra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmaCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaCompra.AutoSize = true;
            this.btnNovaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnNovaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaCompra.FlatAppearance.BorderSize = 0;
            this.btnNovaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovaCompra.Location = new System.Drawing.Point(751, 352);
            this.btnNovaCompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovaCompra.MaximumSize = new System.Drawing.Size(352, 91);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(352, 91);
            this.btnNovaCompra.TabIndex = 3;
            this.btnNovaCompra.Text = "+ Nova Venda";
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // btnVercompra
            // 
            this.btnVercompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVercompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnVercompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVercompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVercompra.FlatAppearance.BorderSize = 0;
            this.btnVercompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVercompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.btnVercompra.ForeColor = System.Drawing.Color.White;
            this.btnVercompra.Location = new System.Drawing.Point(72, 352);
            this.btnVercompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnVercompra.MaximumSize = new System.Drawing.Size(352, 91);
            this.btnVercompra.Name = "btnVercompra";
            this.btnVercompra.Size = new System.Drawing.Size(352, 91);
            this.btnVercompra.TabIndex = 2;
            this.btnVercompra.Text = "Ver Vendas";
            this.btnVercompra.UseVisualStyleBackColor = false;
            this.btnVercompra.Click += new System.EventHandler(this.btnVercompra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(1191, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmaCompra
            // 
            this.btnConfirmaCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfirmaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnConfirmaCompra.FlatAppearance.BorderSize = 0;
            this.btnConfirmaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmaCompra.Location = new System.Drawing.Point(1045, 17);
            this.btnConfirmaCompra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmaCompra.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnConfirmaCompra.Name = "btnConfirmaCompra";
            this.btnConfirmaCompra.Size = new System.Drawing.Size(122, 36);
            this.btnConfirmaCompra.TabIndex = 30;
            this.btnConfirmaCompra.Text = "Deslogar";
            this.btnConfirmaCompra.UseVisualStyleBackColor = false;
            // 
            // frmMenuSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1175, 609);
            this.Controls.Add(this.btnConfirmaCompra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.btnVercompra);
            this.Name = "frmMenuSaida";
            this.Text = "frmMenuSaida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.Button btnVercompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmaCompra;
    }
}