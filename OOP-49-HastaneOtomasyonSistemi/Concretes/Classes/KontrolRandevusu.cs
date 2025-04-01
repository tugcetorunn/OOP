using OOP_49_HastaneOtomasyonSistemi.Abstracts.Classes;
using OOP_49_HastaneOtomasyonSistemi.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_49_HastaneOtomasyonSistemi.Concretes.Classes
{
    public class KontrolRandevusu : Randevu
    {
        public KontrolRandevusu()
        {
            RandevuDetay.Ucret = 0;
        }

        
    }
}
