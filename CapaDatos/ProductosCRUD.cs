using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductosCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public DataSet ObtenerProductos()
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Productos", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(data, "GetProductos");

            adapter.Dispose();
            connection.Close();

            return data;
        }
        public DataSet ObtenerProductoPorCodigo(string codigo)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_Producto_ByCodigo", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@CodigoProducto", codigo);

            adapter.Fill(data, "GetProductoByCodigo");

            adapter.Dispose();
            connection.Close();

            return data;
        }
        public int InsertarProducto(
            string codigoProducto,
            string nombre,
            int existencia,
            decimal precioVenta,
            bool status,
            int categoriaID,
            string unidadMedida)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_Producto", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Existencia", existencia);
            command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@CategoriaID", categoriaID);
            command.Parameters.AddWithValue("@UnidadMedida", unidadMedida);

            int nuevoID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return nuevoID;
        }
        public void ActualizarProducto(
            int productoID,
            string codigoProducto,
            string nombre,
            int existencia,
            decimal precioVenta,
            bool status,
            int categoriaID,
            string unidadMedida)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Update_Producto", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductoID", productoID);
            command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Existencia", existencia);
            command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@CategoriaID", categoriaID);
            command.Parameters.AddWithValue("@UnidadMedida", unidadMedida);

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void EliminarProducto(int productoID)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Delete_Producto", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductoID", productoID);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataSet ObtenerProductosPorCategoria(int categoriaID)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter(
                "SP_Get_Productos_ByCategoria",
                connection);

            adapter.SelectCommand.CommandType =
                CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.AddWithValue(
                "@CategoriaID",
                categoriaID);

            adapter.Fill(data, "GetProductosByCategoria");

            adapter.Dispose();
            connection.Close();

            return data;
        }
    }
}