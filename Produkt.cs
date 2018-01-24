using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkauf
{
    class Produkt
    {
        public Produkt(long produktid, double preis, string bezeichnung, long menge)
        {
            ProduktID = produktid;
            Preis = preis;
            Bezeichnug = bezeichnung;
            Menge = menge;
        }
        public long ProduktID { get; set; }
        public double Preis { get; set; }
        public string Bezeichnug { get; set; }
        public long Menge { get; set; }
    }
}
