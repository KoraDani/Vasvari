using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Erettsegi
{
    public struct Erettsegizo 
    {
        public string nev;
        public string tantargy;
    }
    class Program
    {
        static Erettsegizo[] vizsga = new Erettsegizo[35];
        
        /// <summary>
        /// Megszámolja, hány sor van a fájlban
        /// </summary>
        /// <returns></returns>
        static int ErettsegizoSzam() 
        {
            return File.ReadAllLines("vizsga.txt").Count();
        }

        static void Beolvasas() 
        {
            string fajlnev = "vizsga.txt";
            int index = 0;
            StreamReader sr = new StreamReader(fajlnev);
            //while (!sr.EndOfStream)
            while(sr.Peek() > -1)
            {
                var sor = sr.ReadLine().Split(';');
                vizsga[index].nev = sor[0];
                vizsga[index].tantargy = sor[1];
                index++;
            }
        }

        static void Kiiratas() 
        {
            foreach (Erettsegizo e in vizsga)
            {
                Console.WriteLine(e.nev + ", tantárgya: "+ e.tantargy);
            }
        }

        static string MitTanul(string tanulo) 
        {
            foreach (var item in vizsga)
            {
                if (item.nev == tanulo)
                {
                    return item.tantargy;
                }
                    

            }
            return "Nincs ilyen tanuló";
        }

        static int HanyanVizsgatnak(string tantargy)
        {
            int db = 0;
            foreach (var item in vizsga)
            {
                if (item.tantargy == tantargy)
                {
                    db++;
                }

            }
            return db;
        }

        static List<Erettsegizo> KiVizsgazik(string tantargy)
        {
            List<Erettsegizo> valasz = new List<Erettsegizo>();

            foreach (var item in vizsga)
            {
                if (item.tantargy == tantargy)
                {
                    valasz.Add(item);
                }
            }

            return valasz;
        }
        
        static List<Erettsegizo> TanAzonTanErett(string tanulo)
        {
            List<Erettsegizo> valasz = new List<Erettsegizo>();
            string tantargy = "";

            foreach (var item in vizsga)
            {
                if (item.nev == tanulo)
                {
                    tantargy = item.tantargy;
                }
            }

            foreach (var item in vizsga)
            {
                //Ne szerepeljen benne mégegyszer a paraméteres tanuló
                if (item.tantargy == tantargy && item.nev != tanulo)
                {
                        valasz.Add(item);
                }
            }

            return valasz;
        }


        static void Main(string[] args)
        {
            vizsga = new Erettsegizo[ErettsegizoSzam()];
            Beolvasas();
            Kiiratas();
            Console.WriteLine("Mit tanul Szabo Edit?");
            Console.WriteLine(MitTanul("Szabo Edit"));

            Console.WriteLine("Hányan vizsgáznak Foldrajból");
            Console.WriteLine(HanyanVizsgatnak(MitTanul("Szabo Edit")));

            Console.WriteLine("Ki vizsgázik Földrajzból?");
            foreach (var item in KiVizsgazik("Foldrajz"))
            {
                Console.WriteLine("\t*"+ item.nev);
            }
            Console.WriteLine("Ki vizsgázik Varga Sándor-ral?");
            foreach (var item in TanAzonTanErett("Varga Sandor"))
            {
                Console.WriteLine("\t*" + item.nev);
            }


            //Contains("tehén") == tartalmaz
            string alma = "alma";
            char[] ktomb = alma.ToCharArray();
            //char.IsLetter();
            Console.ReadKey();
        }
    }
}
