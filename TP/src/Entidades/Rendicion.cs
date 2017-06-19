using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Entidades
{
    class Rendicion
    {
        public int id { get; set; }
        public Chofer chofer { get; set; }
        public Turno turno { get; set; }
        public decimal importe { get; set; }
        public List<Viaje> viajes { get; set; }
    }
}
