using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_contraseña;
        private string usu_apellidoNombre;
        protected string usu_rolCodigo;

        // Constructor
        public Usuario(string nombreUsuario, string contraseña)
        {
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contraseña = contraseña;
        }


        public int Usu_ID
        {
            get { return usu_id; }
            set { usu_id = value; }
        }

        public string Usu_NombreUsuario
        {
            get { return usu_nombreUsuario; }
            set { usu_nombreUsuario = value; }
        }

        public string Usu_Contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value; }
        }

        public string Usu_ApellidoNombre
        {
            get { return usu_apellidoNombre; }
            set { usu_apellidoNombre = value; }
        }

        public string Rol_Codigo
        {
            get { return usu_rolCodigo; }
            set { usu_rolCodigo = value; }
        }
    }
}
