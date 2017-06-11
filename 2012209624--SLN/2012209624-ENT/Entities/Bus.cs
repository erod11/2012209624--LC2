using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_ENT.Entities
{
    public class Bus
    {
        public Tripulacion Tripulacion { get; set; }

        public Bus()
        {

        }

        public Bus(Tripulacion tripulacion)
        {
            Tripulacion = tripulacion;
        }

        public string Placa { get; set; }
    }
}
