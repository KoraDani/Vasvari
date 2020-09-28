using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezetek
{
    //Reiter István: 46-56oldal
    //Karsa Zoltán: 7-12
    class Program
    {
        static void Main(string[] args)
        {
            #region Elágazások: if-else

            var input = Console.ReadLine();
            bool ertek; //Alapértelmezetten false
            bool.TryParse(input, out ertek);
            if (ertek)
            {
                Console.WriteLine("A beviteli szöveg értéke IGAZ.");
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("A beviteli szöveg értéke üres.");
            }
            else
            {
                Console.WriteLine("A beviteli szöveg értéke HAMIS.");
            }

            //?: Feltételet operátor 2 válaszúttal
            ertek = bool.TryParse(input, out ertek) ? true : false;
            //változó értéke = (feltétel) ? igaz : hamis;

            // ?? Null ellenőrző operátor

            input = null;
            ertek = bool.Parse(input ?? "False");

            Console.WriteLine(ertek);


            #endregion

            #region Elágazások: switch-case

            int honap = DateTime.Now.Month;
            honap = 123;
            switch (honap)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz van");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár van");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz van");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Tél van");
                    break;
                default:
                    Console.WriteLine("Ilyen hónap nem létezik");
                    break;
            }

            #endregion

            #region Ciklusok: For

            string[] feladat2 = new string[3];
            feladat2[0] = "blabla";
            string[] feladat ={ "kérdés", "megoldás", "válasz" };

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < feladat.Length; j++)
                {
                    Console.WriteLine(i+". "+feladat[j]);
                }
            }


            #endregion

            #region Ciklusok: foreach

            Console.WriteLine();
            Console.WriteLine("A heléyes sorrend: ");
            foreach (var item in feladat)
            {
                Console.Write(item + " ");
            }

            #endregion

            #region Ciklusok: Do-while
            // hátul tesztelő

            Console.WriteLine("\n Adja meg a jelszót.");
            string jelszo = "";

            do
            {
                var bill = Console.ReadKey(true);

                if (bill.Key != ConsoleKey.Backspace && bill.Key != ConsoleKey.Enter)
                {
                    jelszo += bill.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (bill.Key == ConsoleKey.Backspace && jelszo.Length > 0)
                    {
                        //Levágom az utolsó karaktert
                        jelszo = jelszo.Substring(0, (jelszo.Length - 1));
                        Console.Write("\b \b");
                    }

                }



            } while (jelszo != "qwertz");

            Console.WriteLine("\nSikeres a belépés");
            #endregion

            #region Ciklusok: While
            //Előlteszelős ciklus

            Console.WriteLine("A program 5 másodperc múlva bezár");

            DateTime jelen = DateTime.Now;
            DateTime jovo = jelen.AddSeconds(5);

            while (jelen < jovo)
            {
                jelen = DateTime.Now;
                Console.WriteLine(jelen);
            }
            //Kilép az alkalmazásból
            Environment.Exit(0);

            #endregion

            Console.ReadKey();
        }
    }
}
