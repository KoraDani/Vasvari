using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Context
    {
        public List<Focista> Focistak { get; set; }
        public List<FociKlub> FociKlubok { get; set; }
        public Context()
        {
            Focistak = new List<Focista>();
            FociKlubok = new List<FociKlub>();

            //Klubbok létrehozása
            FociKlub BM = new FociKlub(new DateTime(1900,02,27), "Bayer Müncgen", 474.4);
            FociKlub RM = new FociKlub(new DateTime(1902,04,06), "Real Madrid", 577.7);
            //Klubbok hozzáadása a listához
            FociKlubok.Add(BM);
            FociKlubok.Add(RM);

            //Focista létrehozása és a listához adása
            Focistak.Add(new Focista("Benjamin Pavard", 5, 186, 76, true, BM));
            Focistak.Add(new Focista("Robert Lewandowski", 9, 184, 80, true, BM));
            Focistak.Add(new Focista("Joshua Kimmich", 6, 176, 73, true, BM));
            Focistak.Add(new Focista("Sergio Ramos", 4, 184, 82, true, RM));
            Focistak.Add(new Focista("Eden Hazard", 7, 175, 74, true, RM));
            Focistak.Add(new Focista("Thibaut Courtois", 1, 199, 96, false, RM));

            //Focisták hozzá adása a klubhoz

            BM.FocistaLista = Focistak.Where(x => x.focik == BM).ToList();
            RM.FocistaLista = Focistak.Where(x => x.focik == RM).ToList();
        }
    }
}
