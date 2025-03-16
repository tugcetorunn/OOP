using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_34_CalisanPuantajTakip.Enums;

namespace OOP_34_CalisanPuantajTakip.BaseAbstracts
{
    internal class Puantaj
    {
        public Aylar GecerliAy { get; set; }
        public double GelinenGunSayisi { get; set; }

        public override string ToString()
        {
            return $"Puantaj : {GecerliAy} - {GelinenGunSayisi} gün";
        }
    }
}
