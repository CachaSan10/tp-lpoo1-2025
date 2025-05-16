namespace Vistas
{
    partial class FrmDestino
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
            this.btnDesGuardar = new System.Windows.Forms.Button();
            this.txtDesDescripcion = new System.Windows.Forms.TextBox();
            this.txtDesCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesGuardar
            // 
            this.btnDesGuardar.Location = new System.Drawing.Point(225, 189);
            this.btnDesGuardar.Name = "btnDesGuardar";
            this.btnDesGuardar.Size = new System.Drawing.Size(107, 39);
            this.btnDesGuardar.TabIndex = 9;
            this.btnDesGuardar.Text = "Guardar";
            this.btnDesGuardar.UseVisualStyleBackColor = true;
            this.btnDesGuardar.Click += new System.EventHandler(this.btnDesGuardar_Click);
            // 
            // txtDesDescripcion
            // 
            this.txtDesDescripcion.Location = new System.Drawing.Point(203, 134);
            this.txtDesDescripcion.Name = "txtDesDescripcion";
            this.txtDesDescripcion.Size = new System.Drawing.Size(158, 22);
            this.txtDesDescripcion.TabIndex = 8;
            // 
            // txtDesCodigo
            // 
            this.txtDesCodigo.Location = new System.Drawing.Point(203, 84);
            this.txtDesCodigo.Name = "txtDesCodigo";
            this.txtDesCodigo.Size = new System.Drawing.Size(158, 22);
            this.txtDesCodigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // FrmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 313);
            this.Controls.Add(this.btnDesGuardar);
            this.Controls.Add(this.txtDesDescripcion);
            this.Controls.Add(this.txtDesCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDestino";
            this.Text = "Alta de Destino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesGuardar;
        private System.Windows.Forms.TextBox txtDesDescripcion;
        private System.Windows.Forms.TextBox txtDesCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}