using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public bool habilitado { get; set; }
        //public List<Rol> roles { get; set; }
    }
}
