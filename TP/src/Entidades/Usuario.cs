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
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public bool habilitado { get; set; }
        public List<Rol> roles { get; set; }

        public Usuario Mapear(int usuario_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_usuario");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", usuario_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Usuario no encontrado");
                return MapearUsuario(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
        private Usuario MapearUsuario(DataTable data_table)
        {
            try
            {
                Rol rol_mapper = new Rol();
                foreach (DataRow row in data_table.Rows)
                {
                    return new Usuario
                    {
                        id = (int)row.ItemArray[0],
                        usuario = row.ItemArray[1].ToString(),
                        habilitado = (bool)row.ItemArray[2],
                        roles = rol_mapper.MapearRolesUsuario((int)row.ItemArray[0])
                    };
                }
                throw new Exception("Hubo un error al mapear el usuario");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
    }
}
