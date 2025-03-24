using OtobusOtomasyonSonuc.Abstracts.Classes;
using OtobusOtomasyonSonuc.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Concretes.Classes.Koltuklar
{
    public class SoforKoltugu : Koltuk
    {
        public IAracKullanabilir Sofor { get; set; }
        public sbyte KonforSeviyesi { get; set; } // 1-5
    }
}
