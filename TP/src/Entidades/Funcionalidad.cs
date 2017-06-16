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
    public class Funcionalidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Funcionalidad Mapear(int funcionalidad)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidad");
                store_procedure.Parameters.Add(new SqlParameter("@funcionalidad", funcionalidad));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Funcionalidad no encontrada");
                Funcionalidad funcionalidad_mapeada = MapearFuncionalidad(respuesta_consulta);
                return funcionalidad_mapeada;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public Funcionalidad Mapear(string funcionalidad)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidad_nombre");
                store_procedure.Parameters.Add(new SqlParameter("@funcionalidad_nombre", funcionalidad));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Funcionalidad no encontrada");
                Funcionalidad funcionalidad_mapeada = MapearFuncionalidad(respuesta_consulta);
                return funcionalidad_mapeada;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Funcionalidad MapearFuncionalidad(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Funcionalidad
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString(),
                    };
                }
                throw new Exception("Hubo un error al mapear la funcionalidad");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private List<Funcionalidad> MapearFuncionalidades(DataTable data_table)
        {
            try
            {
                List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
                foreach (DataRow row in data_table.Rows)
                {
                    funcionalidades.Add(new Funcionalidad
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString(),
                    });
                }
                return funcionalidades;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<Funcionalidad> MapearFuncionalidadesRol(int rol_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades_rol");
                store_procedure.Parameters.Add(new SqlParameter("@rol", rol_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                return MapearFuncionalidades(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
