using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    class Dij
    {
        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }
        public string TeljesNev => KeresztNev + " " + VezetekNev;
        public Dij(int ev, string tipus, string knev, string vnev)
        {
            Ev = ev;
            Tipus = tipus;
            KeresztNev = knev;
            VezetekNev = vnev;
        }
    }

    class Program
    {
        static List<Dij> dijlista = new List<Dij>();
        static void Main(string[] args)
        {
            #region 2. feladat

            StreamReader sr = new StreamReader("nobel.csv");
            //Beolvassa az első sort
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                dijlista.Add(new Dij(
                    Convert.ToInt32(adat[0]),
                    adat[1],
                    adat[2],
                    adat[3]
                    ));
            }
            sr.Close();
            #endregion

            #region 3. feladat

            Console.WriteLine("3. feladat: ");
            string KeresTipus(string nev)
            {
                foreach (var item in dijlista)
                {
                    if (item.TeljesNev.Equals(nev))
                    {
                        return item.Tipus;
                    }
                }
                return "Nincs ilyen díjazott.";
            }
            Console.Write(KeresTipus("Arthur B. McDonald"));
            #endregion

            #region 4. feladat
            Console.WriteLine("4. feladat: ");
            string KeresNev(int ev, string tipus)
            {
                foreach (var item in dijlista)
                {
                    if (item.Ev.Equals(ev) && item.Tipus.Equals(tipus))
                    {
                        return item.TeljesNev;
                    }
                }
                return "Nem lett kiosztva.";
            }
            Console.Write(KeresNev(2017,"irodalmi"));
            #endregion

            #region 5. feladat
            Console.WriteLine("\n5. feladat: ");

            foreach (var item in dijlista)
            {
                if (item.Ev >= 1990 && item.Tipus.Equals("béke") && string.IsNullOrEmpty(item.VezetekNev))
                {
                    Console.WriteLine("\t"+ item.Ev+ " "+ item.KeresztNev);
                }
            }

            #endregion

            #region 6. feladat
            Console.WriteLine("6. feladat: ");

            foreach (var item in dijlista)
            {
                if (item.VezetekNev.Contains("Curie"))
                {
                    Console.WriteLine("\t"+item.Ev+": "+ item.TeljesNev+ " ("+item.Tipus+")");
                }
            }

            #endregion

            #region 7. feladat
            Console.WriteLine("7. feladat: ");

            var tipusList = dijlista
                .GroupBy(x => x.Tipus)
                .Select(g => new 
            { 
                //Kulcs == Group by által rendezett
                Tipus = g.Key,
                //Count == hányszor fordul elő a kulcs
                Mennyiseg = g.Count()
            });
            foreach (var item in tipusList)
            {
                Console.WriteLine("\t"+item.Tipus+ "\t"+item.Mennyiseg);
            }
            #endregion

            #region 8. feladat
            Console.WriteLine("8. feladat: orvosi.txt");

            using (var sw = new StreamWriter("orvosi.txt"))
            {
                var novekvoLista = dijlista;
                //Megfodítja a listát
                novekvoLista.Reverse();
                //Évszám szerint rendezi növekvő sorrendbe
                var novekLista2 = dijlista.OrderBy(x => x.Ev);
                foreach (var item in novekLista2)
                {
                    if (item.Tipus.Equals("orvosi"))
                    {
                        sw.WriteLine(item.Ev+":"+item.TeljesNev);
                    }
                }
            }

            #endregion
            Console.ReadKey();
        }
    }
}
