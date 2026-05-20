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
        public void PasarClientesAHistorico()
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarClientesAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarCategoriasAHistorico()
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarCategoriasAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarProductosAHistorico()
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarProductosAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarProveedoresAHistorico()
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarProveedoresAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void PasarTodoAHistorico(int? anio)
        {
            connection = objConexion.Conectar();
            connection.Open();
            SqlCommand command = new SqlCommand("sp_PasarTodoAHistorico", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 120;
            SqlParameter param = command.Parameters.Add("@Anio", System.Data.SqlDbType.Int);
            param.Value = anio.HasValue ? (object)anio.Value : DBNull.Value;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}