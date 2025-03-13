using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class Bulgur : Urun, ITETGecerli
    {
        public DateTime TET { get; set; }
        public Durum Durum { get; set; }

        public string UyariVer(ITETGecerli tarihiGecebilirUrun)
        {
            return "TET geçmiş.";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Durum} TET : {TET}";
        }
    }
}
