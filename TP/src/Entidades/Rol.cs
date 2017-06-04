using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Entidades
{
    class Rol
    {
        public string nombre { get; set; }
        public List<String> funcionalidades { get; set; }
        public bool habilitado { get; set; }
    }
}
