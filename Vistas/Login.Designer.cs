namespace Vistas
{
    partial class Login
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.textContrasenia = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(92, 104);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(70, 28);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(110, 31);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(125, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.Text = "Ingrese Nombre";
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(39, 74);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // textContrasenia
            // 
            this.textContrasenia.Location = new System.Drawing.Point(110, 70);
            this.textContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.textContrasenia.Name = "textContrasenia";
            this.textContrasenia.Size = new System.Drawing.Size(125, 20);
            this.textContrasenia.TabIndex = 4;
            this.textContrasenia.Text = "Ingrese contraseña";
            this.textContrasenia.TextChanged += new System.EventHandler(this.textContrasenia_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPerfil});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(256, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuPerfil
            // 
            this.mnuPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministrador,
            this.mnuOperador,
            this.mnuAuditor});
            this.mnuPerfil.Name = "mnuPerfil";
            this.mnuPerfil.Size = new System.Drawing.Size(105, 20);
            this.mnuPerfil.Text = "Seleccione Perfil";
            // 
            // mnuAdministrador
            // 
            this.mnuAdministrador.Name = "mnuAdministrador";
            this.mnuAdministrador.Size = new System.Drawing.Size(150, 22);
            this.mnuAdministrador.Text = "Administrador";
            // 
            // mnuOperador
            // 
            this.mnuOperador.Name = "mnuOperador";
            this.mnuOperador.Size = new System.Drawing.Size(150, 22);
            this.mnuOperador.Text = "Operador";
            // 
            // mnuAuditor
            // 
            this.mnuAuditor.Name = "mnuAuditor";
            this.mnuAuditor.Size = new System.Drawing.Size(150, 22);
            this.mnuAuditor.Text = "Auditor";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 153);
            this.Controls.Add(this.textContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox textContrasenia;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuPerfil;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem mnuOperador;
        private System.Windows.Forms.ToolStripMenuItem mnuAuditor;
    }
}