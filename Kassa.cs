using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkauf
{
    class Kassa
    {
        public Kassa(long kid, long kassastand)
        {
            KID = kid;
            Kassastand = kassastand;
        }

        public long KID { get; set; }
        public long Kassastand { get; set; }
    }
}
