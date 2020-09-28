using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class MyClass
    {
        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }
        public MyClass(int ev, string tipus, string knev, string vnev)
        {
            Ev = ev;
            Tipus = tipus;
            KeresztNev = knev;
            VezetekNev = vnev;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
