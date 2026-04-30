using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class BitacoraCRUD
    {
        private Conexion objConexion = new Conexion();
        private SqlConnection connection;

        public DataSet GetErrors()
        {
            DataSet ds = new DataSet();
            try
            {
                connection = objConexion.Conectar();
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_GetErrors", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "sp_GetErrors");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }
    }
}