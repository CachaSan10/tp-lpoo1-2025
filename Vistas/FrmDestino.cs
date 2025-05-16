using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmDestino : Form
    {
        public FrmDestino()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtDesCodigo.Text = "";
            txtDesDescripcion.Text = "";
        }

        private List<Destino> destinos = new List<Destino>();

        private void btnDesGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los datos de Destino?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Destino oDestino = new Destino();
                oDestino.Des_codigo = int.Parse(txtDesCodigo.Text);
                oDestino.Des_descripcion = txtDesDescripcion.Text;

                destinos.Add(oDestino);

                MessageBox.Show("Datos de Destino: \n" +
                    "Código: " + oDestino.Des_codigo + "\n" +
                    "Descripción: " + oDestino.Des_descripcion + "\n"
                    );

            }

            LimpiarFormulario();
        }
    }
}
