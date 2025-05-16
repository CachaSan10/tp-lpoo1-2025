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
    public partial class Login : Form
    {
        private List<Usuario> usuarios;
        public Login()
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

            // Buscar el usuario en la lista de usuarios
            Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.Usu_NombreUsuario.Equals(user, StringComparison.OrdinalIgnoreCase) && u.Usu_Contraseña == pwd);

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

      
       
    }
}
