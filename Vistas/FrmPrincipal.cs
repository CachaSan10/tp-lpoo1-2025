using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string rolUsuario)
        {
            InitializeComponent();
           ConfigurarMenuPorRol(rolUsuario);
        }

        private void ConfigurarMenuPorRol(string rol)
        {

            sistemaToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem1.Visible = false;
            prestamosToolStripMenuItem1.Visible = false;
            usuariosToolStripMenuItem.Visible = false;
            destinosToolStripMenuItem.Visible = false;
            periodosToolStripMenuItem.Visible = false;
            pagosToolStripMenuItem.Visible = false;
            switch (rol)
            {
                case "Administrador":
                    usuariosToolStripMenuItem.Visible = true;
                    destinosToolStripMenuItem.Visible = true;
                    periodosToolStripMenuItem.Visible = true;
                    break;
                case "Auditor":
                    clientesToolStripMenuItem1.Visible = true;
                    prestamosToolStripMenuItem1.Visible = true;
                    pagosToolStripMenuItem.Visible = true;
                    break;
                case "Operador":
                    usuariosToolStripMenuItem.Visible = true;
                    destinosToolStripMenuItem.Visible = true;
                    periodosToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem1.Visible = true;
                    prestamosToolStripMenuItem1.Visible = true;
                    pagosToolStripMenuItem.Visible = true;
                    
                    break;
            }
        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.Show();
        }

        private void altaDePeriodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPeriodo oFrmPeriodo = new FrmPeriodo();
            oFrmPeriodo.Show();
        }

        private void altaDeDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDestino oFrmDestino = new FrmDestino();
            oFrmDestino.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas salir del sistema?",
                "Confirmación de salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void administrarUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
