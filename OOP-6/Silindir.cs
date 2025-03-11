using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Silindir : Daire
    {
        public double Yukseklik { get; set; }
        public double SilindirAlan { get; set; }
        public double SilindirAlanHesapla()
        {
            SilindirAlan = DaireAlan * Yukseklik;
            return SilindirAlan;
        }
    }
}
