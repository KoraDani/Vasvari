using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Focista
    {
        public string Nev { get; set; }
        public int MezSzam { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }
        public bool Jobblabas { get; set; }
        public FociKlub focik { get; set; }
        public Focista(string nev, int mezszam, int magassag, int suly, bool jobblabas, FociKlub klub)
        {
            this.Nev = nev;
            this.MezSzam = mezszam;
            this.Magassag = magassag;
            this.Suly = suly;
            this.Jobblabas = jobblabas;
            this.focik = klub;
        }
    }
}
