using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {


        public static string get_rol(int iRolCodigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Rol_Descripcion FROM Roles WHERE Rol_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@codigo", iRolCodigo);

            cn.Open();
            string szRolDescripcion = cmd.ExecuteScalar().ToString();
            cn.Close();

            return szRolDescripcion;
        }

        public static int validate_login(string szUsername, string szPassword)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " ISNULL(Rol_Codigo, 0) ";
            cmd.CommandText += " FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " Usu_NombreUsuario=@user COLLATE SQL_Latin1_General_CP1_CS_AS AND ";
            cmd.CommandText += " Usu_Contrasenia=@pass COLLATE SQL_Latin1_General_CP1_CS_AS";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@user", szUsername);
            cmd.Parameters.AddWithValue("@pass", szPassword);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cn.Open();
            int iRolCodigo = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();

            return iRolCodigo;
        }
        public static void agregarUsuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_NombreUsuario,usu_Contrasenia,usu_ApellidoNombre,rol_Codigo) values(@nombreUsuario,@contrasenia,@apellidoNombre,@rolCodigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@apellidoNombre", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rolCodigo", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString );
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static void baja_usuarios(int idUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario WHERE usu_Id=" + idUsuario + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


        }

        public static void modificar_usuario( Usuario usuarioCambiado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = cnn.CreateCommand();
            
           
            
            cmd.CommandText = "UPDATE Usuario SET usu_NombreUsuario='" + usuarioCambiado.Usu_NombreUsuario;
            cmd.CommandText += "' , usu_Contrasenia='" + usuarioCambiado.Usu_Contrasenia;
            cmd.CommandText += "' , usu_ApellidoNombre='" + usuarioCambiado.Usu_ApellidoNombre;
            cmd.CommandText += "' , rol_Codigo='" + usuarioCambiado.Rol_Codigo;
            cmd.CommandText += "' WHERE usu_ID='" + usuarioCambiado.Usu_Id + "'";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscar_usuario(string usu_NombreUsuario)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario LIKE '%" + usu_NombreUsuario + "%';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

        public static Usuario buscar_usuario(int usu_id)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_ID =" + usu_id + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Usuario usuario = new Usuario(int.Parse(row["usu_ID"].ToString()), row["usu_NombreUsuario"].ToString(), row["usu_Contrasenia"].ToString(), row["usu_ApellidoNombre"].ToString(), int.Parse(row["rol_Codigo"].ToString()));
                return usuario;
            }

            return null;
        }

        public static Usuario buscar_por_nombre_usuario(string nombreUsuario)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario =" + nombreUsuario + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Usuario usuario = new Usuario(int.Parse(row["usu_ID"].ToString()), row["usu_NombreUsuario"].ToString(), row["usu_Contrasenia"].ToString(), row["usu_ApellidoNombre"].ToString(), int.Parse(row["rol_Codigo"].ToString()));
                return usuario;
            }

            return null;
        }

        public static bool comprobar_NombreUsuarioExistente(string usu_nombreUsuario)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario ='" + usu_nombreUsuario + "';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            bool bandera = false;
            foreach (DataRow row in dt.Rows)
            {
               if (row["usu_nombreUsuario"].ToString()  == usu_nombreUsuario)
                    bandera =true;
              
            }
            return bandera;
        }
    }
}

