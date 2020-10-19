using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FociKlub
    {
        public DateTime AlapitasD { get; set; }
        public string Nev { get; set; }
        public double Koltsegvetes { get; set; }
        public List<Focista> FocistaLista { get; set; }

        public FociKlub(DateTime alapotd, string nev, double koltseg)
        {
            this.AlapitasD = alapotd;
            this.Nev = nev;
            this.Koltsegvetes = koltseg;
            FocistaLista = new List<Focista>();
        }
    }
}
