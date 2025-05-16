namespace Vistas
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePeriodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDestinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.prestamosToolStripMenuItem1,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(354, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // altaDeClienteToolStripMenuItem
            // 
            this.altaDeClienteToolStripMenuItem.Name = "altaDeClienteToolStripMenuItem";
            this.altaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.altaDeClienteToolStripMenuItem.Text = "Alta de Cliente";
            this.altaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.altaDeClienteToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDePeriodoToolStripMenuItem1,
            this.altaDeDestinoToolStripMenuItem1});
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            // 
            // altaDePeriodoToolStripMenuItem1
            // 
            this.altaDePeriodoToolStripMenuItem1.Name = "altaDePeriodoToolStripMenuItem1";
            this.altaDePeriodoToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.altaDePeriodoToolStripMenuItem1.Text = "Alta de Periodo";
            this.altaDePeriodoToolStripMenuItem1.Click += new System.EventHandler(this.altaDePeriodoToolStripMenuItem1_Click);
            // 
            // altaDeDestinoToolStripMenuItem1
            // 
            this.altaDeDestinoToolStripMenuItem1.Name = "altaDeDestinoToolStripMenuItem1";
            this.altaDeDestinoToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.altaDeDestinoToolStripMenuItem1.Text = "Alta de Destino";
            this.altaDeDestinoToolStripMenuItem1.Click +=new System.EventHandler(this.altaDeDestinoToolStripMenuItem1_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 497);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Prestamos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePeriodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeDestinoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
    }
}