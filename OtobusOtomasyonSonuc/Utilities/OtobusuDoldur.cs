using OtobusOtomasyonSonuc.Abstracts.Classes;
using OtobusOtomasyonSonuc.Concretes.Classes;
using OtobusOtomasyonSonuc.Concretes.Classes.Bagajlar;
using OtobusOtomasyonSonuc.Concretes.Classes.Koltuklar;
using OtobusOtomasyonSonuc.Concretes.Classes.Personeller;
using OtobusOtomasyonSonuc.Concretes.Classes.Yolcular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Utilities
{
    public static class OtobusuDoldur
    {
        static Random random = new Random();
        private static string[] adlar = { "Kemal", "Hande", "Nazlı", "Gaye", "Hakan", "Yaşar" };
        private static string[] soyadlar = { "Kemik", "Hare", "Dere", "Deniz", "Dağ", "Tan" };
        private static string[] hayvanIsimleri = { "Tekir", "Pamuk", "Bulut", "Duman", "Boncuk", "Karabaş" };
        private static string[] hayvanCinsleri = { "Kedi", "Köpek", "Balık", "Tavşan" };


        public static void Doldur(Otobus otobus)
        {
            // şoförleri ata
            for (int i = 0; i < 2; i++)
            {
                otobus.Personeller.Add(new Sofor() { PersonelId = random.Next(1,10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(30, 60), Tecrube = random.Next(1, 30) });
            }

            otobus.SoforKoltugu = new SoforKoltugu { KonforSeviyesi = 4, Sofor = (Sofor)otobus.Personeller[0] };

            // host ve muavin ata
            otobus.Personeller.Add(new Muavin { PersonelId = random.Next(1, 10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(18, 40), Tecrube = random.Next(1, 10) });
            otobus.Personeller.Add(new Host { PersonelId = random.Next(1, 10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(18, 40), Tecrube = random.Next(1, 10) });

            // yolcuları ata
            for (int i = 0; i < otobus.YolcuKoltuklari.Capacity; i++)
            {
                EvcilHayvan evcilHayvan = null;
                int sayi = random.Next(1, 50);
                if (sayi < 5 && otobus.EvcilHayvanlar.Count < otobus.EvcilHayvanlar.Capacity)
                {
                    evcilHayvan = new EvcilHayvan { KoltukId = i + 1, Ad = AdSec(hayvanIsimleri), Cins = AdSec(hayvanCinsleri) };
                }
                Yolcu yolcu = new Yolcu() { Ad = AdSec(adlar), Soyad = AdSec(soyadlar), EvcilHayvan = evcilHayvan, VarisYeri = "Otogar", Bagaj = new Bagaj { KoltukId = i + 1, BagajId = random.Next(1000, 9999), BagajAgirligi = random.Next(5, 20) }};

                otobus.YolcuKoltuklari.Add(new YolcuKoltugu { KoltukNo = i + 1, Yolcu = yolcu });
            }

        }

        private static string AdSec(string[] adlar)
        {
            return adlar[random.Next(adlar.Length - 1)];
        }
    }
}
