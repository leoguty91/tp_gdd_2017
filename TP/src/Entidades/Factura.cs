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
    class Factura
    {
        public int id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public Cliente cliente { get; set; }
        public decimal importe { get; set; }
        public List<Viaje> viajes { get; set; }
        public string Guardar()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_factura");
                store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                store_procedure.Parameters.Add(new SqlParameter("@cliente", cliente.id));
                store_procedure.Parameters.Add(new SqlParameter("@importe", importe));
                store_procedure.Parameters.Add(new SqlParameter("@viajes_facturados", viajes.Count));
                DataTable dt = conexion.EjecutarConsultar(store_procedure);
                int factura_id = 0;
                foreach (DataRow row in dt.Rows)
                {
                    factura_id = (int)row.ItemArray[0];
                }
                GuardarViajes(factura_id);
                return "Se ha creado la factura del cliente correctamente";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void GuardarViajes(int factura_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                foreach (Viaje viaje in viajes)
                {
                    store_procedure = conexion.IniciarStoreProcedure("sp_alta_factura_viaje");
                    store_procedure.Parameters.Add(new SqlParameter("@factura", factura_id));
                    store_procedure.Parameters.Add(new SqlParameter("@viaje", viaje.id));
                    conexion.EjecutarConsultar(store_procedure);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
