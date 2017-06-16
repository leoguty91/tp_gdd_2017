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
    public class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }
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
                    throw new Exception("Rol no encontrado");
                return MapearRol(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public Rol Mapear(string rol)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_rol_nombre");
                store_procedure.Parameters.Add(new SqlParameter("@rol_nombre", rol));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Rol no encontrado");
                return MapearRol(respuesta_consulta);
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
                    Funcionalidad funcionalidad_mapper = new Funcionalidad();
                    return new Rol
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString(),
                        funcionalidades = funcionalidad_mapper.MapearFuncionalidadesRol((int)row.ItemArray[0]),
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
        public List<Rol> MapearRolesUsuario(int usuario_id)
        {
            try
            {
                List<Rol> roles = new List<Rol>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_roles_usuario");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", usuario_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                Rol rol_mapper = new Rol();
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    roles.Add(rol_mapper.Mapear(Convert.ToInt32(row.ItemArray[0])));
                }
                return roles;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
