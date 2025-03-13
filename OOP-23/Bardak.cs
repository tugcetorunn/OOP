using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class Bardak : Urun, IKirilabilir
    {
        public Durum Durum { get; set; }

        public void ListedenCikar(IKirilabilir kirilabilirUrun)
        {
            base.Market.UrunCikar(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"{Durum}";
        }
    }
}
