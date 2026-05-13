using System;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class HistoricoCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;
        public void PasarVentasAHistorico(int anio)
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarVentasAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Anio", anio);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarComprasAHistorico(int anio)
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarComprasAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Anio", anio);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarLavadoPolloAHistorico(int anio)
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarLavadoPolloAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Anio", anio);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}