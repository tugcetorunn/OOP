using OtobusOtomasyonSonuc.Abstracts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Concretes.Classes.Koltuklar
{
    public class MuavinKoltugu : Koltuk
    {
        public Personel Personel { get; set; }
        public bool AcikMi { get; set; } = false;
    }
}
