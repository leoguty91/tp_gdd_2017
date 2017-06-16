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
    public class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Marca Mapear(int id_marca)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_marca");
                store_procedure.Parameters.Add(new SqlParameter("@marca_id", id_marca));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Marca de automovil no encontrada");
                return MapearMarca(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Marca MapearMarca(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Marca
                    {
                        id = (int)row.ItemArray[0],
                        nombre = row.ItemArray[1].ToString()
                    };
                }
                throw new Exception("Hubo un error al mapear la marca del automovil");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<Marca> ObtenerMarcas()
        {
            try
            {
                List<Marca> marcas = new List<Marca>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_marcas");
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                Marca marca_mapper = new Marca();
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    marcas.Add(marca_mapper.Mapear(Convert.ToInt32(row.ItemArray[0])));
                }
                return marcas;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
