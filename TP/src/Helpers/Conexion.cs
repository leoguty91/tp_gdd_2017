using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

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

        public DataTable EjecutarConsultar(SqlCommand cmd)
        {
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    Connector.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Connector.Close();
                    return dt;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al ejecutar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public SqlCommand IniciarStoreProcedure(string nombre_sp)
        {
            string nombre_sp_completo = "GGDP." + nombre_sp;
            SqlCommand cmd = new SqlCommand(nombre_sp_completo, Connector);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
