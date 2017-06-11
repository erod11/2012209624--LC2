using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_ENT.Entities
{
    public class Tripulacion
    {
        public TipoTripulacion TipoTripulacion { get; set; }

        public Tripulacion()
        {
            TipoTripulacion = new TipoTripulacion();
        }
    }
}
