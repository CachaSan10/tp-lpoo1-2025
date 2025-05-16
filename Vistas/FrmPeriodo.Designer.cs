namespace Vistas
{
    partial class FrmPeriodo
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
            this.btnPerGuardar = new System.Windows.Forms.Button();
            this.txtPerDescripcion = new System.Windows.Forms.TextBox();
            this.txtPerCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerGuardar
            // 
            this.btnPerGuardar.Location = new System.Drawing.Point(237, 199);
            this.btnPerGuardar.Name = "btnPerGuardar";
            this.btnPerGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnPerGuardar.TabIndex = 9;
            this.btnPerGuardar.Text = "Guardar";
            this.btnPerGuardar.UseVisualStyleBackColor = true;
            this.btnPerGuardar.Click += new System.EventHandler(this.btnPerGuardar_Click);
            // 
            // txtPerDescripcion
            // 
            this.txtPerDescripcion.Location = new System.Drawing.Point(195, 137);
            this.txtPerDescripcion.Name = "txtPerDescripcion";
            this.txtPerDescripcion.Size = new System.Drawing.Size(188, 22);
            this.txtPerDescripcion.TabIndex = 8;
            // 
            // txtPerCodigo
            // 
            this.txtPerCodigo.Location = new System.Drawing.Point(195, 85);
            this.txtPerCodigo.Name = "txtPerCodigo";
            this.txtPerCodigo.Size = new System.Drawing.Size(188, 22);
            this.txtPerCodigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // FrmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 318);
            this.Controls.Add(this.btnPerGuardar);
            this.Controls.Add(this.txtPerDescripcion);
            this.Controls.Add(this.txtPerCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPeriodo";
            this.Text = "Alta de Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerGuardar;
        private System.Windows.Forms.TextBox txtPerDescripcion;
        private System.Windows.Forms.TextBox txtPerCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}