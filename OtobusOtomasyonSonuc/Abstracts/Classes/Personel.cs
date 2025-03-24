using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Abstracts.Classes
{
    public abstract class Personel : Kisi
    {
        public int PersonelId { get; set; }
        public int Yas { get; set; }
        public int Tecrube { get; set; }

        public override string ToString()
        {
            return PersonelId + " - " + base.ToString() + " - Yaş: " + Yas + " - Tecrübe: " + Tecrube;
        }
    }
}
