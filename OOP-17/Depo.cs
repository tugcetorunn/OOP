using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    internal class Depo
    {
        public double DepoStokTutari { get; set; }
        public List<string> TumUrunler()
        {
            List<string> list = new();
            foreach (var urun in urunler)
            {
                list.Add(urun.ToString());
            }
            return list;
        }
        private List<BaseClass> urunler = new List<BaseClass>();

        public void UrunEkle(BaseClass urun)
        {
            urunler.Add(urun);
        }

        public double TumUrunlerinToplamFiyati()
        {
            double toplam = 0;
            foreach (var urun in urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }
    }
}
