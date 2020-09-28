using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterek
{
    class Program
    {
        //Karsa Zoltán: 23. oldal
        static void Main(string[] args)
        {
            Udvozles("Haza akarok menni");
            Udvozles();

            int a = 2, b = 2;
            ErtekKiiras(a, b);

            Console.WriteLine("Két taf összegének a négyzete "+ Hatvany(ref a, ref b));
            ErtekKiiras(a, b);

            Console.WriteLine();

            bool paros = false;
            a = 4;
            Console.WriteLine("A következő szám páros e? " + a);
            Paros1(a,out paros);
            Console.WriteLine(paros);

            Console.ReadKey();
        }
        //Alapértelmezett praméter
        static void Udvozles(string nev = "Idegen") {

            Console.WriteLine("Üdvözöllek "+ nev + "!" );
        }

        static void ErtekKiiras(int elso, int masodik) 
        {
            Console.WriteLine("Első szám {0}, második szám {1}",elso,masodik);
        }

        static int Osszeadas(int elso, int masodik) {
            return elso + masodik;
        }

        //Összegük hatványa
        //Referencia szintű paraméter átadás
        static double Hatvany(ref int elso,ref int masodik) {

            elso = 3;
            masodik = 3;

            Console.WriteLine();
            Console.WriteLine($"Új értéket adtam meg:{elso},{masodik}");
            return Math.Pow(elso+masodik,2);
        }

        static void Paros1(int szam, out bool eredmeny) 
        {
            eredmeny = szam % 2 == 0;
        }
    }
}
