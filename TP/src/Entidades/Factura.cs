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
        public Factura Mapear(DateTime fecha_inicio, DateTime fecha_fin, Cliente cliente)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_factura");
                store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                store_procedure.Parameters.Add(new SqlParameter("@cliente", cliente.id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Factura no encontrada");
                return MapearFactura(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Factura MapearFactura(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    Cliente cliente_mapper = new Cliente();
                    return new Factura
                    {
                        id = (int)row.ItemArray[0],
                        fecha_inicio = Convert.ToDateTime(row.ItemArray[1]),
                        fecha_fin = Convert.ToDateTime(row.ItemArray[2]),
                        cliente = cliente_mapper.Mapear((int)row.ItemArray[3]),
                        importe = Convert.ToDecimal(row.ItemArray[4]),
                        viajes = new List<Viaje>()
                    };
                }
                throw new Exception("Hubo un error al mapear la factura");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public string Guardar()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                store_procedure = conexion.IniciarStoreProcedure("sp_alta_factura");
                store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                store_procedure.Parameters.Add(new SqlParameter("@cliente", cliente.id));
                store_procedure.Parameters.Add(new SqlParameter("@importe", importe));
                store_procedure.Parameters.Add(new SqlParameter("@viajes_facturados", viajes.Count));
                conexion.EjecutarConsultar(store_procedure);

                store_procedure = conexion.IniciarStoreProcedure("sp_obtener_factura");
                store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                store_procedure.Parameters.Add(new SqlParameter("@cliente", cliente.id));
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
