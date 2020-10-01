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



            #endregion
            Console.ReadKey();
        }
    }
}
