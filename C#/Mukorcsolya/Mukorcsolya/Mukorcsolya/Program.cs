using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mukorcsolya
{
    class Gyakorlatsor
    {
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public double TechPont { get; set; }
        public double kompPont { get; set; }
        public int hibaPont { get; set; }
        public double osszPont { get; set; }

        public Gyakorlatsor(string nev, string orszag, double tpont, double kpont, int hiba)
        {
            Nev = nev;
            Orszag = orszag;
            TechPont = tpont;
            kompPont = kpont;
            hibaPont = hiba;
        }
    }
    class Program
    {


        static List<Gyakorlatsor> rovidProgram = new List<Gyakorlatsor>();
        static List<Gyakorlatsor> donto = new List<Gyakorlatsor>();
        static void Main(string[] args)
        {

            #region 1. feladat

            FileStream fs = new FileStream("rovidprogram.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //Első sor átugrása
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine();
                string[] adat = sor.Split(';');
                rovidProgram.Add(new Gyakorlatsor(
                    adat[0], adat[1], 
                    // Kultúrális különbség miatt ki kell cserélni a pontott veszzőre
                    Convert.ToDouble(adat[2].Replace('.', ',')),
                    Convert.ToDouble(adat[3].Replace('.', ',')),
                    Convert.ToInt32(adat[4])
                    ));
            }
            sr.Close();
            fs.Close();

            fs = new FileStream("donto.csv", FileMode.Open);
            sr = new StreamReader(fs);
            //Első sor átugrása
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine();
                string[] adat = sor.Split(';');
                donto.Add(new Gyakorlatsor(
                    adat[0], adat[1],
                    // Kultúrális különbség miatt ki kell cserélni a pontott veszzőre
                    Convert.ToDouble(adat[2].Replace('.', ',')),// CultureInfo.InvariantCulture using system.globalization
                    Convert.ToDouble(adat[3].Replace('.', ',')),
                    Convert.ToInt32(adat[4])
                    ));
            }
            sr.Close();
            fs.Close();
            #endregion

            #region 2. feladat
            Console.WriteLine("2. feladat: " + rovidProgram.Count());
            Console.WriteLine("\tA rövid programban {0} induló volt",rovidProgram.Count());
            #endregion

            #region 3. feladat
            Console.WriteLine("3. feladat: ");

            bool vaneMagyar = false;
            int index = 0;
            while (!vaneMagyar && index < donto.Count())
            {
                if (donto[index].Orszag.Equals("HUN"))
                {
                    vaneMagyar = true;
                }
                else
                {
                    index++;
                }

            }
            if (vaneMagyar)
            {
                Console.WriteLine("\tA magyar versenyző bejutott a döntőbe");
            }
            else
            {
                Console.WriteLine("\tNem jutott be magyar a döntőbe");
            }
            #endregion

            #region 4. feladat

            double OsszpontKalk(string nev)
            {
                double pont = 0;

                foreach (var item in rovidProgram)
                {
                    if (item.Nev == nev)
                    {
                        pont += item.TechPont + item.kompPont - item.hibaPont;
                    }
                }
                foreach (var item in donto)
                {
                    if (item.Nev == nev)
                    {
                        pont += item.TechPont + item.kompPont - item.hibaPont;
                    }
                }
                return pont;
            }

            #endregion

            #region 5. feladat

            Console.WriteLine("5. feladat\n\tKérem a versenyző nevét");
            string versenyzonev = Console.ReadLine();

            #endregion

            #region 6. feladat
            double bekertpont = OsszpontKalk(versenyzonev);
            if (bekertpont == 0)
            {
                Console.WriteLine("\tIlyen nevű induló nem volt!");
            }
            else
            {
                Console.WriteLine("6. feladat\n\tA versenyző összpontszáma: " + bekertpont);
            }
            #endregion

            #region 7. feladat

            Console.WriteLine("7. feladat");
            //Két ugyanolyan elem nem szerepelhet benne
            //Csak egyedi elemeket tratalmaz
            //első megoldás
            HashSet<string> bejutottOrszágok = new HashSet<string>();
            foreach (var item in donto)
            {
                bejutottOrszágok.Add(item.Orszag);
            }
            foreach (var orszag in bejutottOrszágok)
            {
                int db = 0;
                foreach (var versenyzo in donto)
                {
                    if (versenyzo.Orszag == orszag)
                    {
                        db++;
                    }
                }
                if (db > 1)
                {
                    Console.WriteLine("\t"+orszag + ": "+ db+" versenyző");
                }
            }
            //2. megoldás LINQ

            var bejutott2 = donto
                .GroupBy(x=> x.Orszag)
                .Select(o => new { OrszagNev= o.Key, Mennyiseg = o.Count()});
            foreach (var item in bejutott2)
            {
                if (item.Mennyiseg > 1)
                {
                    Console.WriteLine("\t"+ item.OrszagNev+ ": "+ item.Mennyiseg+" versenyző");
                }
            }
            #endregion

            #region 8. feladat

            Console.WriteLine("8. feladat");
            //Frissítsük az öszpontszámokat
            foreach (var item in donto)
            {
                item.osszPont = OsszpontKalk(item.Nev);
            }
            //Rendezés öszzpontszám alapján
            var helyezesLista = donto.OrderByDescending(x => x.osszPont);
            fs = new FileStream("vegeredmeny.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            int helyezes = 1;
            foreach (var item in helyezesLista)
            {
                sw.WriteLine($"{helyezes};{item.Nev};{item.Orszag};{item.osszPont}");
                helyezes++;
            }
            sw.Close();
            fs.Close();
            #endregion
            Console.ReadKey();
        }
    }
}
