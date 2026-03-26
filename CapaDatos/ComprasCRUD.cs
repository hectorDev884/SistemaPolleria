using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ComprasCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;

        public void InsertarCompraCompleta(
            int proveedorID,
            DateTime fecha,
            decimal total,
            DataTable detalles)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("sp_InsertarCompra", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProveedorID", proveedorID);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@Total", total);

            SqlParameter paramDetalles =
                command.Parameters.AddWithValue("@Detalles", detalles);
            paramDetalles.SqlDbType = SqlDbType.Structured;
            paramDetalles.TypeName = "dbo.DetalleCompraType";

            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataSet GetUltimaCompraID()
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("GetUltimaCompraID", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetUltimaCompraID");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }
    }
}