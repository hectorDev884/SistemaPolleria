using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Conexion
    {
        private SqlConnection connection;

        public SqlConnection Conectar()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            return connection;
        }

        public SqlConnection ConectarHistorico()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionHistorico"].ConnectionString);
            return connection;
        }
    }
}
