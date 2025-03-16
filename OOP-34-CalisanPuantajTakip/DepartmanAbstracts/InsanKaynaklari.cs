using OOP_34_CalisanPuantajTakip.BaseAbstracts;
using OOP_34_CalisanPuantajTakip.Enums;
using OOP_34_CalisanPuantajTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_34_CalisanPuantajTakip.DepartmanAbstracts
{
    internal class InsanKaynaklari : Departman, IMaasGoruntuleme, IPuantajHazirlama, IPuantajGoruntuleme
    {
        public string AylikPuantajOlustur(Calisan calisan, Aylar ay, int yil, double calismaSuresi)
        {
            if (calisan.Puantajlar != null)
            {
                foreach (var puantaj in calisan.Puantajlar)
                {
                    if (puantaj.GecerliAy != ay)
                    {
                        calisan.Puantajlar.Add(new Puantaj { GecerliAy = ay, GelinenGunSayisi = calismaSuresi });
                        return $"{calisan.ToString()} - Puantaj : {ay} - {calismaSuresi} gün";
                    }

                    return "Bu aya ait puantaj zaten oluşturulmuş.";
                }
            }

            // bu kısım metodlaştırılabilir.
            calisan.Puantajlar.Add(new Puantaj { GecerliAy = ay, GelinenGunSayisi = calismaSuresi });
            return $"{calisan.ToString()} - Puantaj : {ay} - {calismaSuresi} gün";
        }

        public string PuantajGoruntuleme(Calisan calisan)
        {
            string puantajMesaji = null;

            foreach (var puantaj in calisan.Puantajlar)
            {
                puantajMesaji += $"{puantaj.ToString()} \n";
            }

            return puantajMesaji;
        }

        public string MaasGoruntule(Calisan calisan)
        {
            return $"{calisan.ToString()} - Maaş : {calisan.Maas} tl";
        }
    }
}
