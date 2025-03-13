using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class Market
    {
        public List<Urun> Urunler { get; set; }
        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
        }
        public void UrunCikar(Urun urun)
        {
            if (urun.)
            {

            }
            Urunler.Remove(urun);
        }
    }
}
