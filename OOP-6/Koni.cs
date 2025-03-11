using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Koni : Silindir
    {
        public double KoniAlan { get; set; }
        public double KoniAlanHesapla()
        {
            KoniAlan = SilindirAlan / 3;
            return KoniAlan;
        }
    }
}
