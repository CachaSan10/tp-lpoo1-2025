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
            this.btnSalir = new System.Windows.Forms.Button();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sistemaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.periodosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(153, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 28);
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
            this.altaDeDestinoToolStripMenuItem1.Click += new System.EventHandler(this.altaDeDestinoToolStripMenuItem1_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 454);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 41);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click_1);
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarDestinosToolStripMenuItem});
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.destinosToolStripMenuItem.Text = "Destinos";
            // 
            // administrarDestinosToolStripMenuItem
            // 
            this.administrarDestinosToolStripMenuItem.Name = "administrarDestinosToolStripMenuItem";
            this.administrarDestinosToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.administrarDestinosToolStripMenuItem.Text = "Administrar Destinos";
            // 
            // periodosToolStripMenuItem
            // 
            this.periodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPeriodoToolStripMenuItem});
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.periodosToolStripMenuItem.Text = "Periodos";
            // 
            // administrarPeriodoToolStripMenuItem
            // 
            this.administrarPeriodoToolStripMenuItem.Name = "administrarPeriodoToolStripMenuItem";
            this.administrarPeriodoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.administrarPeriodoToolStripMenuItem.Text = "Administrar Periodo";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // administrarPagosToolStripMenuItem
            // 
            this.administrarPagosToolStripMenuItem.Name = "administrarPagosToolStripMenuItem";
            this.administrarPagosToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.administrarPagosToolStripMenuItem.Text = "Administrar Pagos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 497);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Prestamos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPagosToolStripMenuItem;
    }
}