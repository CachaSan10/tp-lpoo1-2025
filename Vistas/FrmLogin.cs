using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase; // Asegúrate de incluir el espacio de nombres
namespace Vistas
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {

            usuarios = new List<Usuario>
            {
                new Usuario("Administrador", "123"),
                new Usuario("Operador", "1234"),
                new Usuario("Auditor", "12345")
            };
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = textNombre.Text;
            string pwd = textContrasenia.Text;
            Usuario usuarioEncontrado = null;

            // Buscar el usuario en la lista de usuarios

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Usu_NombreUsuario == user && usuario.Usu_Contraseña == pwd)
                {
                    usuarioEncontrado = usuario;
                }

            }


            if (usuarioEncontrado != null)
            {
                Form f1 = new FrmPrincipal();
                this.Hide(); // Opcional: ocultar el formulario de login
                // Si se encontró el usuario, abrir el formulario principal

                f1.Show();

            }
            else
            {
                // Si no se encontró el usuario
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            // Ejemplo: Cambiar el color de fondo
            btnIngresar.BackColor = Color.Violet;
            // Ejemplo: Cambiar el color del texto
            btnIngresar.ForeColor = Color.GreenYellow;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.Black;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

       

        

    }
}
