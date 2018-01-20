using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkauf
{
    class Mitarbeiter
    {
        public Mitarbeiter(long mid, bool za,string benutzername,string passwort)
        {
            MID = mid;
            ZugriffKassa = za;
            Benutzername = benutzername;
            Passwort = passwort;
        }

        public long MID { get; set; }
        public bool ZugriffKassa { get; set; }
        public string Benutzername { get; set; }
        public string Passwort { get; set; }
    }
}
