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
        public Viaje Mapear(int viaje_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_viaje");
                store_procedure.Parameters.Add(new SqlParameter("@viaje_id", viaje_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Viaje no encontrado");
                return MapearViaje(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Viaje MapearViaje(DataTable data_table)
        {
            try
            {
                Automovil automovil_mapper = new Automovil();
                Chofer chofer_mapper = new Chofer();
                Turno turno_mapper = new Turno();
                Cliente cliente_mapper = new Cliente();
                foreach (DataRow row in data_table.Rows)
                {
                    return new Viaje
                    {
                        id = Convert.ToInt32(row.ItemArray[0]),
                        automovil = automovil_mapper.Mapear(Convert.ToInt32(row.ItemArray[1])),
                        chofer = chofer_mapper.Mapear(Convert.ToInt32(row.ItemArray[2])),
                        turno = turno_mapper.Mapear(Convert.ToInt32(row.ItemArray[3])),
                        cantidad_kilometros = Convert.ToInt32(row.ItemArray[4]),
                        fecha_inicio = Convert.ToDateTime(row.ItemArray[5]),
                        fecha_fin = Convert.ToDateTime(row.ItemArray[6]),
                        cliente = cliente_mapper.Mapear(Convert.ToInt32(row.ItemArray[7]))
                    };
                }
                throw new Exception("Hubo un error al mapear el viaje");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
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
