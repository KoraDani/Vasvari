using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszögek.ViewsInterfaces
{
    interface ISokszogView : INegyzetView
    {
        string Kerulet { set; }
        string Terulet { set; }
        List<string> SokszogList { set; }

    }
}
