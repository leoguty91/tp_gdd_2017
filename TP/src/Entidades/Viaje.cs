using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Helpers;

namespace UberFrba.Entidades
{
    class Viaje
    {
        public int id { get; set; }
        public Automovil automovil { get; set; }
        public Chofer chofer { get; set; }
        public Turno turno { get; set; }
        public int cantidad_kilometros { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public Cliente cliente { get; set; }
        public string Guardar()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_viaje");
                store_procedure.Parameters.Add(new SqlParameter("@chofer", chofer.id));
                store_procedure.Parameters.Add(new SqlParameter("@automovil", automovil.id));
                store_procedure.Parameters.Add(new SqlParameter("@turno", turno.id));
                store_procedure.Parameters.Add(new SqlParameter("@cantidad_kilometros", cantidad_kilometros));
                store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                store_procedure.Parameters.Add(new SqlParameter("@cliente", cliente.id));
                conexion.EjecutarConsultar(store_procedure);
                return "Se ha creado el viaje correctamente";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
