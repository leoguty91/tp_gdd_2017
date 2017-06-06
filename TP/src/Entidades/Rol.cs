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
    class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<String> funcionalidades { get; set; }
        public bool habilitado { get; set; }
        public Rol Mapear(int rol)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_rol");
                store_procedure.Parameters.Add(new SqlParameter("@rol", rol));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                {
                    throw new Exception("Rol no encontrado");
                }
                Rol rol_mapeado = MapearRol(respuesta_consulta);
                return rol_mapeado;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Rol MapearRol(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Rol
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString(),
                        funcionalidades = new List<string>(), // TODO Ver si se mapean las funcionalidades
                        habilitado = (bool)row.ItemArray[2]
                    };
                }
                throw new Exception("Hubo un error al mapear al rol");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
