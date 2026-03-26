using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedoresCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public DataSet ObtenerProveedores()
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Proveedores", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(data, "GetProveedores");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public DataSet ObtenerProveedorPorID(int id)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Proveedor_ByID", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.AddWithValue("@ProveedorID", id);

            adapter.Fill(data, "GetProveedorByID");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public int InsertarProveedor(
            string nombre,
            string telefono,
            string direccion,
            bool status)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_Proveedor", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Direccion", direccion);
            command.Parameters.AddWithValue("@Status", status);

            int nuevoID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return nuevoID;
        }


        public void ActualizarProveedor(
            int id,
            string nombre,
            string telefono,
            string direccion,
            bool status)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Update_Proveedor", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProveedorID", id);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Direccion", direccion);
            command.Parameters.AddWithValue("@Status", status);

            command.ExecuteNonQuery();

            connection.Close();
        }


        public void EliminarProveedor(int id)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Delete_Proveedor", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProveedorID", id);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
