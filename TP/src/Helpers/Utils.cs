using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using UberFrba.Entidades;

namespace UberFrba.Helpers
{
    public class SingletonUsuario
    {
        private static Usuario instance = null;
        protected SingletonUsuario() { }
        public static Usuario Instance
        {
            get
            {
                if (instance == null)
                    instance = new Usuario();
                return instance;
            }
        }
        public static void Registrar(Usuario usuario)
        {
            instance = usuario;
        }
    }
    class Utils
    {
        public static string Encriptar(string password)
        {
            SHA256Managed encriptador_manager = new SHA256Managed();

            byte[] input_bytes = Encoding.Unicode.GetBytes(password);
            byte[] hashed_bytes = encriptador_manager.ComputeHash(input_bytes);

            StringBuilder string_encriptado = new StringBuilder();

            for (int i = 0; i < hashed_bytes.Length; i++)
                string_encriptado.Append(hashed_bytes[i].ToString("X2"));

            return string_encriptado.ToString();
        }
    }
    class Entidad
    {
        public const int NUEVO = 0;
    }
}
