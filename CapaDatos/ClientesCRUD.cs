using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClientesCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public DataSet ObtenerClientes()
        {
            DataSet data = new DataSet();
            connection = objConexion.Conectar();
            connection.Open();
            adapter = new SqlDataAdapter("SP_Clientes_GetAll", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(data, "GetClientes");
            adapter.Dispose();
            connection.Close();
            return data;
        }
        public DataSet ObtenerClientePorID(int id)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Cliente_ByID", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.AddWithValue("@ClienteID", id);

            adapter.Fill(data, "GetClienteByID");

            adapter.Dispose();
            connection.Close();

            return data;
        }
        public int InsertarCliente(string nombre,
                           string apellido,
                           string telefono,
                           bool status)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command = new SqlCommand("SP_Clientes_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Status", status);

            int nuevoID = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return nuevoID;
        }

        public void ActualizarCliente(int id,
                              string nombre,
                              string apellido,
                              string telefono,
                              bool status)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command = new SqlCommand("SP_Clientes_Update", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ClienteID", id);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Status", status);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarCliente(int id)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command = new SqlCommand("SP_Clientes_Delete", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ClienteID", id);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
