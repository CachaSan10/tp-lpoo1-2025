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
        public FrmPrincipal()
        {
            InitializeComponent();
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

    }
}
