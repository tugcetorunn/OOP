using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Daire
    {
        public double Yaricap { get; set; }
        public double DaireAlan { get; set; }
        public double DaireAlanHesapla()
        {
            DaireAlan = Yaricap * Yaricap * double.Pi;
            return DaireAlan;
        }
    }
}
