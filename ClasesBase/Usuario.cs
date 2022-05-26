using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_Id;
        private string usu_NombreUsuario;
        private string usu_Contrasenia;
        private string usu_ApellidoNombre;
        private int rol_Codigo;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }

        public string Usu_Contrasenia
        {
            get { return usu_Contrasenia; }
            set { usu_Contrasenia = value; }
        }

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario()
        {

        }
        public Usuario( string nombreUsuario, string contrasenia, string apellidoNombre, int rolCodigo)
        {
 
            this.usu_NombreUsuario = nombreUsuario;
            this.usu_Contrasenia = contrasenia;
            this.usu_ApellidoNombre = apellidoNombre;
            this.rol_Codigo = rolCodigo;
        }

        public Usuario(int idUsuario, string nombreUsuario, string contrasenia, string apellidoNombre, int rolCodigo)
        {
            this.usu_Id = idUsuario;
            this.usu_NombreUsuario = nombreUsuario;
            this.usu_Contrasenia = contrasenia;
            this.usu_ApellidoNombre = apellidoNombre;
            this.rol_Codigo = rolCodigo;
        }

        public override string ToString()
        {
            return string.Format("Usuario: {0} ,Contraseña: {1},NombreCompleto: {2} , RolId: {3}",usu_NombreUsuario ,usu_Contrasenia, usu_ApellidoNombre,rol_Codigo );
        }  
    }
}
