using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UberFrba.Helpers
{
    class Conexion
    {
        public SqlConnection Connector { get; set; }
        public SqlCommand Command { get; set; }

        public Conexion()
        {
            var connection_string = ConfigurationManager.ConnectionStrings["UberFrba"].ConnectionString;
            Connector = new SqlConnection(connection_string);
        }
    }
}
