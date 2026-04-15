using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoLavadoCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public DataSet ObtenerLavados()
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_LavadoPollo", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(data, "GetLavadoPollo");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public DataSet ObtenerLavadoPorID(int lavadoPolloID)
        {
            DataSet data = new DataSet();

            connection = objConexion.Conectar();
            connection.Open();

            adapter = new SqlDataAdapter("SP_Get_LavadoPollo_ByID", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@LavadoPolloID", lavadoPolloID);

            adapter.Fill(data, "GetLavadoPolloByID");

            adapter.Dispose();
            connection.Close();

            return data;
        }

        public int InsertarLavadoPollo(
            DateTime fecha,
            int productoALavarID,
            int productoLavadoID,
            decimal cantidadALavar,
            decimal cantidadDesperdicios)
        {
            connection = objConexion.Conectar();
            connection.Open();

            SqlCommand command =
                new SqlCommand("sp_InsertarLavadoPollo", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@ProductoALavarID", productoALavarID);
            command.Parameters.AddWithValue("@ProductoLavadoID", productoLavadoID);
            command.Parameters.AddWithValue("@CantidadALavar", cantidadALavar);
            command.Parameters.AddWithValue("@CantidadDesperdicios", cantidadDesperdicios);

            int nuevoID =
                Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return nuevoID;
        }

        public DataSet GetLavadosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetLavadosPollosPorFecha", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetLavadosPorFecha");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

        public DataSet GetResumenDesperdicioPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetResumenDesperdicionPorFecha", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "GetResumenDesperdicio");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }


    }
}