using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkauf
{
    class Rechnung
    {
        public Rechnung(long produktid, long menge)
        {
            ProduktID= produktid;
            Menge=menge;
        }
        public long ProduktID { get; set; }
        public long Menge { get; set; }
    }
}

