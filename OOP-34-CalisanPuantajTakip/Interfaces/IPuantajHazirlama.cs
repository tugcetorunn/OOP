using OOP_34_CalisanPuantajTakip.BaseAbstracts;
using OOP_34_CalisanPuantajTakip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_34_CalisanPuantajTakip.Interfaces
{
    internal interface IPuantajHazirlama
    {
        string AylikPuantajOlustur(Calisan calisan, Aylar ay, int yil, double calismaSuresi);
    }
}
