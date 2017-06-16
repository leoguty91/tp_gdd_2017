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
    public class Turno
    {
        public int id { get; set; }
        public int hora_inicio { get; set; }
        public int hora_fin { get; set; }
        public string descripcion { get; set; }
        public decimal valor_kilometro { get; set; }
        public decimal precio_base { get; set; }
        public bool habilitado { get; set; }
        public Turno Mapear(int turno_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_turno");
                store_procedure.Parameters.Add(new SqlParameter("@turno_id", turno_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Turno no encontrado");
                return MapearTurno(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Turno MapearTurno(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Turno
                    {
                        id = (int)row.ItemArray[0],
                        hora_inicio = Convert.ToInt32(row.ItemArray[1]),
                        hora_fin = Convert.ToInt32(row.ItemArray[2]),
                        descripcion = row.ItemArray[3].ToString(),
                        valor_kilometro = Convert.ToDecimal(row.ItemArray[4]),
                        precio_base = Convert.ToDecimal(row.ItemArray[5]),
                        habilitado = (bool)row.ItemArray[6]
                    };
                }
                throw new Exception("Hubo un error al mapear el turno");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<Turno> ObtenerTurnos()
        {
            try
            {
                List<Turno> turnos = new List<Turno>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_turnos");
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                Turno turno_mapper = new Turno();
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    turnos.Add(turno_mapper.Mapear(Convert.ToInt32(row.ItemArray[0])));
                }
                return turnos;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
