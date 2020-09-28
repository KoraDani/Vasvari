using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            int x; //deklaráció
            x = 10; //defínició
            int y = 11; // deklaráció és defínició

            byte bájt = 250; //előjel nélküli 8 bites egész szám (0...255)
            char karakter = 'X'; // Egy Unicode karakter
            bool búúl = true; //Logikai tipus, értéke lehet (true, 1), vagy lehet (false, 0)
            búúl = Convert.ToBoolean(0);

            int integer = 0; //Előjeles, 32 bites egész szám, (-2147483648...2147483647)
            float flóath = 6 / 2.3F;
            flóath = (float) 5 /4; // előjeles csak 7 számjegyik képes számolni
            double dábül = 6 / 2.3; dábül = 6 / 2.3D; //15-17 számjegyik képes számolni
            decimal decimál = 6 / 2.3M; //25-29 számjegyik képes pontosan számolni
            //FONTOS: pénz összeget mindig decimálban tároljuk

            string sztring = "szöveg";// Unicode karakterek összefűzve
            object obdzsekt = new object();//Minden más tipus őse

            var elso = "bariéböl";
            var masodik = 2; // Tetszőleges típusú változó, azonnal értéket kell neki adni

            const string alma = "alma";
            /*Konstans típusú változónál éstéket nem lehet felülírni
            
            void tabasz() { 
                alma = "piros alma"
            }
            */

            string semmi = "";
            string nihil = null;

            Console.WriteLine(semmi);
            Console.WriteLine(nihil);

            if (semmi != nihil)
            {
                Console.WriteLine("A null nem egyenértékű a  \"\"-jellel!");
            }



            Console.ReadKey();
        }
    }
}
