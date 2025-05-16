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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtIngresos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private List<Cliente> clientes = new List<Cliente>();

        private void bntGuardar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea guardar los datos del cliente?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_dni = txtDNI.Text;
                oCliente.Cli_nombre = txtNombre.Text;
                oCliente.Cli_apellido = txtApellido.Text;
                oCliente.Cli_sexo = txtSexo.Text;
                oCliente.Cli_fechaNacimiento = dtpFechaNacimiento.Value;
                oCliente.Cli_ingresos = decimal.Parse(txtIngresos.Text);
                oCliente.Cli_direccion = txtDireccion.Text;
                oCliente.Cli_telefono = txtTelefono.Text;

                clientes.Add(oCliente);

                MessageBox.Show("Cliente Cargado:\n" +
                    "DNI: " + oCliente.Cli_dni + "\n" +
                    "Nombre: " + oCliente.Cli_nombre + "\n" +
                    "Apellido: " + oCliente.Cli_apellido + "\n" +
                    "Género: " + oCliente.Cli_sexo + "\n" +
                    "Fecha de Nacimiento: " + oCliente.Cli_fechaNacimiento.ToShortDateString() + "\n" +
                    "Ingresos: $" + oCliente.Cli_ingresos.ToString("N2") + "\n" +
                    "Dirección: " + oCliente.Cli_direccion + "\n" +
                    "Teléfono: " + oCliente.Cli_telefono + "\n"
               );
            }

            LimpiarFormulario();

        }
    }
}
