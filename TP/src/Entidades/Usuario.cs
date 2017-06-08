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
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public bool habilitado { get; set; }
        public List<Rol> roles { get; set; }

        public Usuario Mapear(DataTable data_table)
        {
            try
            {
                foreach (DataRow row in data_table.Rows)
                {
                    return new Usuario
                    {
                        id = (int)row.ItemArray[0],
                        usuario = row.ItemArray[1].ToString(),
                        habilitado = (bool)row.ItemArray[2],
                        roles = MapearRoles((int)row.ItemArray[0])
                    };
                }
                throw new Exception("Hubo un error al mapear al usuario");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private List<Rol> MapearRoles(int usuario)
        {
            try
            {
                List<Rol> roles = new List<Rol>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_roles_usuario");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", usuario));
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
        private List<string> MapearFuncionalidades(int rol)
        {
            try
            {
                List<string> funcionalidades = new List<string>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades");
                store_procedure.Parameters.Add(new SqlParameter("@rol", rol));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                foreach (DataRow row in respuesta_consulta.Rows)
                {
                    funcionalidades.Add(row.ItemArray[0].ToString());
                }
                return funcionalidades;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
