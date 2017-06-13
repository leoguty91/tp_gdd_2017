﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Helpers;

namespace UberFrba.Entidades
{
    public class Automovil
    {
        public int id { get; set; }
        //public Marca marca { get; set; } // TODO
        public string modelo { get; set; }
        public string patente { get; set; }
        //public Turno turno { get; set; } // TODO
        //public Chofer chofer { get; set; } // TODO
        public bool habilitado { get; set; }
        public Automovil Mapear(int automovil_id)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_cliente");
                store_procedure.Parameters.Add(new SqlParameter("@automovil_id", automovil_id));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                if (respuesta_consulta.Rows.Count == 0)
                    throw new Exception("Automovil no encontrado");
                return MapearAutomovil(respuesta_consulta);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private Automovil MapearAutomovil(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Automovil
                    {
                        id = (int)row.ItemArray[0],
                        // marca = row.ItemArray[1].ToString(),
                        modelo = row.ItemArray[2].ToString(),
                        patente = row.ItemArray[3].ToString(),
                        // turno = row.ItemArray[4].ToString(),
                        // chofer = Convert.ToInt32(row.ItemArray[5]),
                        habilitado = (bool)row.ItemArray[6]
                    };
                }
                throw new Exception("Hubo un error al mapear al cliente");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
