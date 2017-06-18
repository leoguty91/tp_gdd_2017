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
    public class Automovil
    {
        public int id { get; set; }
        public Marca marca { get; set; }
        public string modelo { get; set; }
        public string patente { get; set; }
        public Turno turno { get; set; }
        public Chofer chofer { get; set; }
        public bool habilitado { get; set; }
        public Automovil Mapear(int automovil_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_automovil");
                store_procedure.Parameters.Add(new SqlParameter("@automovil_id", automovil_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Automovil no encontrado");
                return MapearAutomovil(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Automovil MapearAutomovil(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    Marca marca_mapper = new Marca();
                    Turno turno_mapper = new Turno();
                    Chofer chofer_mapper = new Chofer();
                    return new Automovil
                    {
                        id = (int)row.ItemArray[0],
                        marca = marca_mapper.Mapear((int)row.ItemArray[1]),
                        modelo = row.ItemArray[2].ToString(),
                        patente = row.ItemArray[3].ToString(),
                        turno = turno_mapper.Mapear((int)row.ItemArray[4]),
                        chofer = chofer_mapper.Mapear((int)row.ItemArray[5]),
                        habilitado = (bool)row.ItemArray[6]
                    };
                }
                throw new Exception("Hubo un error al mapear el automovil");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<Automovil> ObtenerAutomoviles()
        {
            try
            {
                List<Automovil> automoviles = new List<Automovil>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_automoviles");
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                Automovil automovil_mapper = new Automovil();
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    automoviles.Add(automovil_mapper.Mapear(Convert.ToInt32(row.ItemArray[0])));
                }
                return automoviles;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public string Guardar()
        {
            Conexion conexion = new Conexion();
            SqlCommand store_procedure;
            if (id == Entidad.NUEVO)
            {
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_automovil");
            }
            else
            {
                store_procedure = conexion.IniciarStoreProcedure("sp_modificacion_automovil");
                store_procedure.Parameters.Add(new SqlParameter("@automovil_id", id));
            }
            store_procedure.Parameters.Add(new SqlParameter("@marca", marca.id));
            store_procedure.Parameters.Add(new SqlParameter("@modelo", modelo));
            store_procedure.Parameters.Add(new SqlParameter("@patente", patente));
            store_procedure.Parameters.Add(new SqlParameter("@turno", turno.id));
            store_procedure.Parameters.Add(new SqlParameter("@chofer", chofer.id));
            store_procedure.Parameters.Add(new SqlParameter("@habilitado", habilitado));
            conexion.EjecutarConsultar(store_procedure);
            string mensaje_ok;
            if (id == Entidad.NUEVO)
            {
                mensaje_ok = String.Format("Se ha creado el automovil {0} {1} {2}", marca.nombre, modelo, patente);
            }
            else
            {
                mensaje_ok = String.Format("Se ha modificado el automovil {0} {1} {2}", marca.nombre, modelo, patente);
            }
            return mensaje_ok;
        }
    }
}
