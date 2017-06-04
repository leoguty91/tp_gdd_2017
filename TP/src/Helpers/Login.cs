﻿using System;
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
                if (respuesta_consulta.Rows.Count == 0) {
                    throw new Exception("Combinacion de usuario/password incorrecta");
                }
                Usuario user = MapearUsuario(respuesta_consulta);
                if (!user.habilitado) {
                    throw new Exception("El usuario se encuentra deshabilitado");
                }
                MessageBox.Show("Login correcto", " Login ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return user;
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
                foreach (DataRow row in data_table.Rows)
                {
                    return new Usuario
                    {
                        id = (int)row.ItemArray[0],
                        usuario = row.ItemArray[1].ToString(),
                        habilitado = (bool)row.ItemArray[2]
                    };
                }
                throw new Exception("Hubo un error al mapear al usuario");
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}