using OtobusOtomasyonSistemi.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSistemi.Classes
{
    public class Yolcu : BaseKisi
    {
        public List<EvcilHayvan>? EvcilHayvanlar { get; set; }
        public double? BagajKg { get; set; }
        // public string BinecegiLokasyon { get; set; }
        public string InecegiLokasyon { get; set; }

        public Func<double?, bool> bagajFazlaMi = (BagajKg) => BagajKg >= 20;
    }
}
