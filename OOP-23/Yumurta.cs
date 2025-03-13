using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class Yumurta : Urun, IKirilabilir, ISKTGecerli
    {
        public DateTime SKT { get; set; }
        public Durum Durum { get; set; }

        public void ListedenCikar(IKirilabilir kirilabilirUrun)
        {
            base.Market.UrunCikar(this);
        }

        public void ListedenCikar(ISKTGecerli bozulabilirUrun)
        {
            base.Market.UrunCikar(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"{Durum} + SKT : {SKT}";
        }
    }
}
