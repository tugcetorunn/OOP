using OOP_24.Abstracts;
using OOP_24.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_24
{
    internal class Market
    {
        List<Urun> urunler = new List<Urun>();

        public void UrunEkle(Urun urun)
        {
            urunler.Add(urun);
        }
        public void UrunCikar(Urun urun)
        {
            urunler.Remove(urun);
        }

        public List<Urun> Urunler => urunler;

        public List<Urun> KirikUrunler()
        {
            // return urunler.Where(u => u is IKirilabilir).ToList();
            List<Urun> kirikUrunler = new List<Urun>();

            foreach (var urun in urunler)
            {
                if (urun is IKirilabilir && ((IKirilabilir)urun).KirikMi)
                    kirikUrunler.Add(urun);
            }
            return kirikUrunler;
        }

        public IEnumerable<Urun> BozukUrunler()
        {
            foreach (var urun in urunler)
            {
                if (urun is ISKT && ((ISKT)urun).SKT < DateTime.Now)
                    yield return urun; // yield return ile geriye bir IEnumerable döndürüyoruz. şarta uyanlar ienumerable'a ekleniyor. tip ienumerable olmalı.
            }
        }

        public IEnumerable<Urun> TarihiGecmisUrunler()
        {
            foreach (var urun in urunler)
            {
                if (urun is ITET && ((ITET)urun).TET < DateTime.Now)
                    yield return urun;
            }
        }
    }
}
