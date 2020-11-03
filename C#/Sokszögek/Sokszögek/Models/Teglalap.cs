using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszögek.Models
{
    class Teglalap : Sokszog
    {
        public double oldalB { get; set; }
        public Teglalap(double A,double B) : base(A)
        {
            oldalB = B;
        }

        public override double Kerulet()
        {
            return 2 * (oldalA + oldalB);
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
