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
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string codigo_postal { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool habilitado { get; set; }
        public Usuario usuario { get; set; }
        public Cliente Mapear(int cliente_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_cliente");
                store_procedure.Parameters.Add(new SqlParameter("@cliente_id", cliente_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Cliente no encontrado");
                return MapearCliente(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Cliente MapearCliente(DataTable data_table)
        {
            try
            {
                Usuario usuario_mapper = new Usuario();
                foreach (DataRow row in data_table.Rows)
                {
                    return new Cliente
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString(),
                        apellido = row.ItemArray[2].ToString(),
                        dni = Convert.ToInt32(row.ItemArray[3]),
                        mail = row.ItemArray[4].ToString(),
                        telefono = Convert.ToInt32(row.ItemArray[5]),
                        direccion = row.ItemArray[6].ToString(),
                        codigo_postal = row.ItemArray[7].ToString(),
                        fecha_nacimiento = Convert.ToDateTime(row.ItemArray[8]),
                        habilitado = (bool)row.ItemArray[9],
                        usuario = usuario_mapper.Mapear((int)row.ItemArray[10])
                    };
                }
                throw new Exception("Hubo un error al mapear al cliente");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_clientes");
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                Cliente cliente_mapper = new Cliente();
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    clientes.Add(cliente_mapper.Mapear(Convert.ToInt32(row.ItemArray[0])));
                }
                return clientes;
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
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_cliente");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", usuario.id));
            }
            else
            {
                store_procedure = conexion.IniciarStoreProcedure("sp_modificacion_cliente");
                store_procedure.Parameters.Add(new SqlParameter("@cliente_id", id));
            }
            store_procedure.Parameters.Add(new SqlParameter("@nombre", nombre));
            store_procedure.Parameters.Add(new SqlParameter("@apellido", apellido));
            store_procedure.Parameters.Add(new SqlParameter("@dni", dni));
            store_procedure.Parameters.Add(new SqlParameter("@mail", mail));
            store_procedure.Parameters.Add(new SqlParameter("@telefono", telefono));
            store_procedure.Parameters.Add(new SqlParameter("@direccion", direccion));
            store_procedure.Parameters.Add(new SqlParameter("@codigo_postal", codigo_postal));
            store_procedure.Parameters.Add(new SqlParameter("@fecha_nacimiento", fecha_nacimiento.Date));
            store_procedure.Parameters.Add(new SqlParameter("@habilitado", habilitado));
            conexion.EjecutarConsultar(store_procedure);
            string mensaje_ok;
            if (id == Entidad.NUEVO)
            {
                mensaje_ok = String.Format("Se ha creado el cliente {0} {1}", nombre, apellido);
            }
            else
            {
                mensaje_ok = String.Format("Se ha modificado el cliente {0} {1}", nombre, apellido);
            }
            return mensaje_ok;
        }
    }
}
