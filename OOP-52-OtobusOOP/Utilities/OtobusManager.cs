using Newtonsoft.Json;
using OOP_52_OtobusOOP.Concretes.Classes;
using OOP_52_OtobusOOP.Concretes.Classes.Bagajlar;
using OOP_52_OtobusOOP.Concretes.Classes.Calisanlar;
using OOP_52_OtobusOOP.Concretes.Classes.Koltuklar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_52_OtobusOOP.Utilities
{
    public static class OtobusManager
    {
        static Random rnd = new Random();
        private static List<string> adlar = new() { "Kemal", "Hande", "Nazlı", "Gaye", "Hakan", "Yaşar" };
        private static List<string> soyadlar = new() { "Kemik", "Hare", "Dere", "Deniz", "Dağ", "Tan" };
        private static List<string> hayvanIsimleri = new() { "Tekir", "Pamuk", "Bulut", "Duman", "Boncuk", "Karabaş" };
        private static List<string> hayvanCinsleri = new() { "Kedi", "Köpek", "Balık", "Tavşan" };
        public static void OtobusOlustur(Otobus otobus)
        {
            for (int i = 0; i < 2; i++)
            {
                otobus.Calisanlar.Add(new Sofor() { CalisanId = i + 1, Ad = AdOlustur(adlar), Soyad = AdOlustur(soyadlar), EhliyetNo = rnd.Next(1000, 9999).ToString(), Yas = rnd.Next(40, 60), Tecrube = rnd.Next(5, 30) });
            }

            otobus.SoforKoltugu.Sofor = (Sofor)otobus.Calisanlar[0];

            otobus.Calisanlar.Add(new Muavin() { CalisanId = 3, Ad = AdOlustur(adlar), Soyad = AdOlustur(soyadlar), EhliyetNo = rnd.Next(1000, 9999).ToString(), Yas = rnd.Next(25, 55), Tecrube = rnd.Next(2, 15) });
            otobus.Calisanlar.Add(new Host() { CalisanId = 4, Ad = AdOlustur(adlar), Soyad = AdOlustur(soyadlar), Yas = rnd.Next(18, 45), Tecrube = rnd.Next(2, 15) });

            for (int i = 0; i < otobus.YolcuKoltuklari.Capacity; i++)
            {
                EvcilHayvan evcilHayvan = null;
                if (rnd.Next(20) < 5 && otobus.EvcilHayvanlar.Count < otobus.EvcilHayvanlar.Capacity)
                {
                    evcilHayvan = new() { KoltukId = i + 1, Ad = AdOlustur(hayvanIsimleri), Cins = AdOlustur(hayvanCinsleri) };
                    otobus.EvcilHayvanlar.Add(evcilHayvan);
                }
                Yolcu yolcu = new Yolcu() { Ad = AdOlustur(adlar), Soyad = AdOlustur(soyadlar), VarisYeri = "otogar", Bagaj = new Bagaj { BagajId = i + 1, KoltukId = i + 1, BagajAgirligi = rnd.Next(3, 20) }, EvcilHayvan = evcilHayvan };

                otobus.Bagajlar.Add(yolcu.Bagaj);

                otobus.YolcuKoltuklari.Add(new YolcuKoltugu() { KoltukId = i + 1, Yolcu = yolcu });
            }

        }

        public static string AdOlustur(List<string> liste)
        {
            return liste[rnd.Next(liste.Count - 1)];
        }

        public static void DosyayaYaz<T>(string dosyaAdi, List<T> entity)
        {
            string json = JsonConvert.SerializeObject(entity, Formatting.Indented);
            File.WriteAllText(dosyaAdi, json);
        }
    }
}
