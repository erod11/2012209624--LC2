using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_ENT.Entities
{
    public class Encomienda
    {
        public LugarViaje LugarViaje { get; set; }
        public Bus Bus { get; set; }


        private Encomienda()
        {
            LugarViaje = new LugarViaje();
        }

        public Encomienda(Bus bus)
        {
            LugarViaje = new LugarViaje();
            Bus = bus;
        }

        public string Beneficiario { get; set; }
    }
}
