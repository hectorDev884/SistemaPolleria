using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriasCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public DataSet ObtenerCategorias()
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Categorias", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(data, "GetCategorias");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public DataSet ObtenerCategoriaPorID(int id)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Categoria_ById", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.AddWithValue("@CategoriaID", id);

            adapter.Fill(data, "GetCategoriaByID");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public int InsertarCategoria(
            string nombre,
            string descripcion)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_Categoria", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            int nuevoID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return nuevoID;
        }

        public void ActualizarCategoria(
            int id,
            string nombre,
            string descripcion)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Update_Categoria", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoriaID", id);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarCategoria(int id)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Delete_Categoria", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoriaID", id);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}