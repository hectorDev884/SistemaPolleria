using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class VentasCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public int InsertarPedido(int clienteID)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_Pedido", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ClienteID", clienteID);

            int pedidoID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return pedidoID;
        }

        public int InsertarVenta(
            DateTime fecha,
            decimal total,
            int? pedidoID)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_Venta", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@Total", total);

            if (pedidoID == null)
                command.Parameters.AddWithValue("@PedidoID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@PedidoID", pedidoID);

            int ventaID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return ventaID;
        }

        public void InsertarDetalleVenta(
            int ventaID,
            int productoID,
            decimal precioUnitario,
            int cantidad,
            decimal subtotal)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("SP_Insert_DetalleVenta", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@VentaID", ventaID);
            command.Parameters.AddWithValue("@ProductoID", productoID);
            command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            command.Parameters.AddWithValue("@Subtotal", subtotal);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void InsertarVentaCompleta(
            DateTime fecha,
            decimal total,
            int? clienteID,     // si es null = venta sin cliente
            DataTable detalles)
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command =
                new SqlCommand("sp_InsertarVenta", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@Total", total);

            if (clienteID == null)
                command.Parameters.AddWithValue("@ClienteID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ClienteID", clienteID);

            SqlParameter paramDetalles =
                command.Parameters.AddWithValue("@Detalles", detalles);
            paramDetalles.SqlDbType = SqlDbType.Structured;
            paramDetalles.TypeName = "dbo.DetalleVentaType";

            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataSet GetUltimaVentaID()
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("GetUltimaVentaID", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetUltimaVentaID");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }
        public DataSet GetVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetVentasPorFecha", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetVentasPorFecha");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

        public DataSet GetVentasPorCliente(int clienteID)
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetVentasPorCliente", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetVentasPorCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

        public DataSet GetTopProductosVendidos(int top)
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetTopProductosVendidos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Top", top);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetTopProductos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

    }
}