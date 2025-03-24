using OtobusOtomasyonSonuc.Abstracts.Classes;
using OtobusOtomasyonSonuc.Concretes.Classes.Bagajlar;
using OtobusOtomasyonSonuc.Concretes.Classes.Koltuklar;
using OtobusOtomasyonSonuc.Concretes.Classes.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Concretes.Classes
{
    public class Otobus
    {
        public Otobus(int koltukKapasitesi)
        {
            SoforKoltugu = new SoforKoltugu();
            MuavinKoltugu = new MuavinKoltugu();
            YolcuKoltuklari = new List<YolcuKoltugu>(koltukKapasitesi);
            Bagajlar = new List<Bagaj>();
            EvcilHayvanlar = new List<EvcilHayvan>(3);
            Personeller = new List<Personel>();
        }
        public SoforKoltugu SoforKoltugu { get; set; }
        public List<Personel> Personeller { get; set; } // SoforKoltugunda oturan 1 kişi diğer şoförü de ekliyoruz.
        public MuavinKoltugu MuavinKoltugu { get; set; }
        public List<YolcuKoltugu> YolcuKoltuklari { get; set; } // yolcu koltukları
        public List<Bagaj> Bagajlar { get; set; }
        public List<EvcilHayvan> EvcilHayvanlar { get; set; }
    }

}
