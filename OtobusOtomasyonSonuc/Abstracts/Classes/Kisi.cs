using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Abstracts.Classes
{
    public abstract class Kisi : Canli
    {
        public string Soyad { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Soyad;
        }
    }
}
