using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase; 
namespace Vistas
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            
           
        }

        /**
         * Este metodo carga todos los datos de usuarios 
         * */
        private static DataTable CargarUsuarios()
        {
            string conexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BD\prestamos.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dtUsuario = new DataTable();
            da.Fill(dtUsuario);
            
           return dtUsuario;
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = CargarUsuarios();


            string user = textNombre.Text;
            string pwd = textContrasenia.Text;
            string nombreUsuarioEncontrado = "";
            bool usuarioEncontrado = false;
            string idRolEncontrado = "";

            Console.WriteLine("CANTIDAD: " + dtUsuarios.Rows.Count);
            if (dtUsuarios.Rows.Count > 0)
            {
                foreach (DataRow row in dtUsuarios.Rows)
                {
                   
                    int idUsuario = (int)row["usu_id"];
                    string nombreUsuario = row["usu_nombreUsuario"].ToString();
                    string contraseña = row["usu_contraseña"].ToString();
                    string apellidoNombre = row["usu_apellidoNombre"].ToString();
                    string idRol = row["rol_codigo"].ToString();

                    if (nombreUsuario.Equals(user) && contraseña.Equals(pwd)) {
                        usuarioEncontrado = true;
                        idRolEncontrado = idRol;
                        nombreUsuarioEncontrado = apellidoNombre;
                    }

                    if (usuarioEncontrado) {
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("NO HAY NADA");
            }

            string conexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BD\prestamos.mdf;Integrated Security=True;User Instance=True";
            string rolDescripcion = "";
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                cnn.Open(); // Abrir la conexión

                // --- 3. Crear el Comando SQL con Parámetros (¡Crucial para la seguridad!) ---
                // Asumo que tu tabla se llama 'Rol' y tiene columnas 'id_rol' y 'rol_descripcion'.
                string query = "SELECT rol_descripcion FROM Rol WHERE rol_codigo = @idRol";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    // --- 4. Añadir el Parámetro de forma segura ---
                    cmd.Parameters.AddWithValue("@idRol", idRolEncontrado);

                    // --- 5. Ejecutar el Comando y obtener un único valor con ExecuteScalar() ---
                    object result = cmd.ExecuteScalar();

                    // --- 6. Verificar y Asignar el Resultado ---
                    if (result != null)
                    {
                        rolDescripcion = result.ToString(); // Convertir el resultado a string
                    }
                } // SqlCommand se libera aquí
            } // SqlConn
            
            
           


            if (usuarioEncontrado)
            {
                Form f1 = new FrmPrincipal(rolDescripcion);
                this.Hide(); // Opcional: ocultar el formulario de login
                // Si se encontró el usuario, abrir el formulario principal
                MessageBox.Show("Bienvenido al sistema " + nombreUsuarioEncontrado + "Con rol: " + rolDescripcion);
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
            btnIngresar.BackColor = Color.DarkCyan;
            // Ejemplo: Cambiar el color del texto
            btnIngresar.ForeColor = Color.LightSalmon;

            btnIngresar.Font = new System.Drawing.Font("Arial Black", 7, System.Drawing.FontStyle.Italic);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);
        }

        private void btnCancelar_Click(object sender, EventArgs e)

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

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Font = new System.Drawing.Font("Georgia", 7, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);

            
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            
                
           

             
        }

         

    }
}
