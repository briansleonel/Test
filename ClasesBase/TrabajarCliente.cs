using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static void insert_cliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI, Cli_Nombre, Cli_Apellido, Cli_Direccion, OS_CUIT, Cli_NroCarnet) ";
            cmd.CommandText += "values(@DNI, @nombre, @apellido, @direccion, @CUIT, @nroCarnet)";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@CUIT", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", oCliente.Cli_NroCarnet);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable list_clientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Cli_DNI as 'DNI', ";
            cmd.CommandText += " Cli_Nombre as 'Nombre', ";
            cmd.CommandText += " Cli_Apellido as 'Apellido', ";
            cmd.CommandText += " Cli_Direccion as 'Direccion', ";
            cmd.CommandText += " OS_CUIT as 'CUIT', ";
            cmd.CommandText += " Cli_NroCarnet as 'Nro de Carnet' ";
            cmd.CommandText += " FROM Cliente ";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void update_cliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET ";
            cmd.CommandText += " Cli_Nombre=@nombre, ";
            cmd.CommandText += " Cli_Apellido=@apellido, ";
            cmd.CommandText += " Cli_Direccion=@direccion, ";
            cmd.CommandText += " OS_CUIT=@CUIT, ";
            cmd.CommandText += " Cli_NroCarnet=@nroCarnet ";
            cmd.CommandText += " WHERE Cli_DNI=@DNI";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@CUIT", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", oCliente.Cli_NroCarnet);
            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void delete_cliente(string szDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI=@DNI";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", szDNI);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable search_clientes(string szApellido, string szDireccion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Cli_DNI as 'DNI', ";
            cmd.CommandText += " Cli_Nombre as 'Nombre', ";
            cmd.CommandText += " Cli_Apellido as 'Apellido', ";
            cmd.CommandText += " Cli_Direccion as 'Direccion', ";
            cmd.CommandText += " OS_CUIT as 'CUIT', ";
            cmd.CommandText += " Cli_NroCarnet as 'Nro de Carnet' ";
            cmd.CommandText += " FROM Cliente ";
            cmd.CommandText += " WHERE Cli_Apellido LIKE @apellido AND Cli_Direccion LIKE @direccion ";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@apellido", "%" + szApellido + "%");
            cmd.Parameters.AddWithValue("@direccion", "%" + szDireccion + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
