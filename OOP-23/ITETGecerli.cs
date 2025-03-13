using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal interface ITETGecerli
    {
        DateTime TET { get; set; }
        Durum Durum { get; set; }
        string UyariVer(ITETGecerli tarihiGecebilirUrun);
    }
}
