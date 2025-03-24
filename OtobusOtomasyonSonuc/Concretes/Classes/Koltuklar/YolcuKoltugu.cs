using OtobusOtomasyonSonuc.Abstracts.Classes;
using OtobusOtomasyonSonuc.Concretes.Classes.Yolcular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Concretes.Classes.Koltuklar
{
    public class YolcuKoltugu : Koltuk
    {
        public int KoltukNo { get; set; }
        public Yolcu Yolcu { get; set; }

        public override string ToString()
        {
            return $"{KoltukNo} - {Yolcu.ToString()}";
        }
    }
}
