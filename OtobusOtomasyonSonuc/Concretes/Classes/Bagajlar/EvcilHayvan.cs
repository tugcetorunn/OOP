using OtobusOtomasyonSonuc.Abstracts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSonuc.Concretes.Classes.Bagajlar
{
    public class EvcilHayvan : Canli
    {
        public string Cins { get; set; }
        public int KoltukId { get; set; } // kime ait olduğunu görmek için

        public override string ToString()
        {
            return $"{KoltukId} - {base.ToString()} - Cinsi: {Cins}" ;
        }
    }
}
