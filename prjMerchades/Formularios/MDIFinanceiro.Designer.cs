namespace prjMerchades.Formularios
{
    partial class MDIFinanceiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFinanceiro));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.RelFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.SeaGreen;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1169, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelFinanceiro,
            this.parcelasClientesToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.logoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // RelFinanceiro
            // 
            this.RelFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.RelFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelFinanceiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RelFinanceiro.Name = "RelFinanceiro";
            this.RelFinanceiro.Size = new System.Drawing.Size(211, 28);
            this.RelFinanceiro.Text = "Relatório Financeiro";
            this.RelFinanceiro.Click += new System.EventHandler(this.RelFinanceiro_Click);
            // 
            // parcelasClientesToolStripMenuItem
            // 
            this.parcelasClientesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.parcelasClientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelasClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.parcelasClientesToolStripMenuItem.Name = "parcelasClientesToolStripMenuItem";
            this.parcelasClientesToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.parcelasClientesToolStripMenuItem.Text = "Parcelas Clientes";
            this.parcelasClientesToolStripMenuItem.Click += new System.EventHandler(this.parcelasClientesToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fecharToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.fecharToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // logoToolStripMenuItem
            // 
            this.logoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoToolStripMenuItem.Image")));
            this.logoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            this.logoToolStripMenuItem.Size = new System.Drawing.Size(28, 28);
            this.logoToolStripMenuItem.Text = "   ";
            // 
            // MDIFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIFinanceiro";
            this.Text = "MDIFinanceiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIFinanceiro_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem parcelasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoToolStripMenuItem;
    }
}



