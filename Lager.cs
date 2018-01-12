using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkauf
{
    class Lager
    {
        public Lager(long lid, long pid, long kid, long mid )
        {
            LagerID= lid;
            ProduktID = pid;
            KID = kid;
            MID = mid;
        }

        public long LagerID { get; set; }
        public long ProduktID { get; set; }
        public long KID { get; set; }
        public long MID { get; set; }
    }
}
