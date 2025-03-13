using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal interface ISKTGecerli
    {
        DateTime SKT { get; set; }
        Durum Durum { get; set; }
        void ListedenCikar(ISKTGecerli bozulabilirUrun);
    }
}
