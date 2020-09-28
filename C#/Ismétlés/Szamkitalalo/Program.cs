using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Üdvözöljük a számkitaláló játékban " +
                "\nAdjon megy egy kezdőértéket és egy végértéket a tartomány megadásához");
            Console.WriteLine("Adjon meg egy kezdőszámot");

            int kezdoertek = 0, vegertek = 0;
            bool IsNumber = false;

            while (!IsNumber)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out kezdoertek)) 
                {
                    IsNumber = true;
                    break;
                }
                Console.WriteLine("Kérem adjon meg egy számot");
            }
            IsNumber = false;
            Console.WriteLine("Kérem adja meg a végértéket");
            while (!IsNumber)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out vegertek))
                {
                    IsNumber = true;
                    break;
                }
                Console.WriteLine("Kérem adjon meg egy számot");
            }

            Random rnd = new Random();
            int randszam = rnd.Next(kezdoertek, vegertek);

            int? tipp = null;

            do
            {
                Console.Write("Tipp: ");
                tipp = Convert.ToInt32(Console.ReadLine());
                //Bekérjük és átalakítjuk a stringet intté

                if (tipp < randszam)
                {
                    Console.WriteLine("Nagyobb számra gondoltam");
                }
                else if (tipp > randszam)
                {
                    Console.WriteLine("Kisebb számra gondoltam");
                }
                else
                {
                    Console.WriteLine("Eltaláltad");
                }
            } while (tipp != randszam);
            //A ciklus addig fog futni míg a tipp nem lesz egyenlő a generált számmal
            Console.ReadKey();
        }
    }
}
