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
    class Login
    {
        public Usuario ObtenerUsuario(string usuario, string password)
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
                    MessageBox.Show("Combinacion de usuario/password incorrecta", " Login erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario user = MapearUsuario(respuesta_consulta);
                MessageBox.Show("Login correcto", " Login ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return user;
            }
            catch (Exception) { return null; }
        }
        private Usuario MapearUsuario(DataTable data_table)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        usuarios.Add(new Usuario
                        {
                            usuario = item.ToString(),
                            habilitado = true
                        });
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrió un error al hacer login. Por favor, intente nuevamente.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usuarios.First();
        }
    }
}
