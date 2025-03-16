using OOP_34_CalisanPuantajTakip.BaseAbstracts;
using OOP_34_CalisanPuantajTakip.PozisyonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_34_CalisanPuantajTakip.PozisyonAbstracts
{
    internal class GenelMudur : IGenelMudur
    {
        public void MaasDuzenle(Calisan calisan, double maas)
        {
            calisan.Maas = maas;
        }

        public string MaasGoruntule(Calisan calisan)
        {
            return $"{calisan.ToString()} - Maaş : {calisan.Maas} tl";
        }
    }
}
