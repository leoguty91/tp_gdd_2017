using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Helpers;

namespace UberFrba.Entidades
{
    class Rendicion
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public Chofer chofer { get; set; }
        public Turno turno { get; set; }
        public decimal importe { get; set; }
        public List<Viaje> viajes { get; set; }
        public string Guardar()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_rendicion");
                store_procedure.Parameters.Add(new SqlParameter("@fecha", fecha));
                store_procedure.Parameters.Add(new SqlParameter("@chofer", chofer.id));
                store_procedure.Parameters.Add(new SqlParameter("@turno", turno.id));
                store_procedure.Parameters.Add(new SqlParameter("@importe", importe));
                DataTable dt = conexion.EjecutarConsultar(store_procedure);
                int id_rendicion = 0;
                foreach (DataRow row in dt.Rows)
                {
                    id_rendicion = (int)row.ItemArray[0];
                }
                GuardarViajes(id_rendicion);
                return "Se ha creado la rendicion del chofer correctamente";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void GuardarViajes(int rendicion_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                foreach (Viaje viaje in viajes)
                {
                    store_procedure = conexion.IniciarStoreProcedure("sp_alta_rendicion_viaje");
                    store_procedure.Parameters.Add(new SqlParameter("@rendicion", rendicion_id));
                    store_procedure.Parameters.Add(new SqlParameter("@viaje", viaje.id));
                    conexion.EjecutarConsultar(store_procedure);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
