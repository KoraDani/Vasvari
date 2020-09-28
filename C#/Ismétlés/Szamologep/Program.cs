using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            var osszeg = 0;
            string input = "";

            do
            {
                input = Console.ReadLine();
                int resz = 0;
                int.TryParse(input, out resz);
                osszeg += resz;

            } while (!string.IsNullOrWhiteSpace(input));

            Console.WriteLine("A végősszeg: " + osszeg);

            Console.ReadKey();
        }
    }
}
