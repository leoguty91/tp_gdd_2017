using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UberFrba.Entidades;

namespace UberFrba.Helpers
{
    class LoginHelper
    {
        public void ObtenerUsuario(string usuario, string password)
        {
            try
            {
                string password_encriptado = Utils.Encriptar(password);
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_login");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", usuario));
                store_procedure.Parameters.Add(new SqlParameter("@password", password));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Combinacion de usuario/password incorrecta");
                int usuario_id = ObtenerUsuarioId(respuesta_consulta);
                Usuario user_mapper = new Usuario();
                Usuario user = user_mapper.Mapear(usuario_id);
                if (!user.habilitado)
                    throw new Exception("El usuario se encuentra deshabilitado");
                if (user.roles.Count == 0)
                    throw new Exception("El usuario no tiene roles disponibles");
                SingletonUsuario.Registrar(user);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private int ObtenerUsuarioId(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return (int)row.ItemArray[0];
                }
                throw new Exception("Hubo un error al obtener el id del usuario");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
