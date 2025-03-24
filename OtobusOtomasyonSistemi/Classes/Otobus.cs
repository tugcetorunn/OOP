using OtobusOtomasyonSistemi.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSistemi.Classes
{
    public class Otobus
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public string KalkisLokasyon { get; set; }
        public List<string>? AraLokasyonlar { get; set; }
        public string VarisLokasyon { get; set; }
        public DateTime KalkisSaati { get; set; }
        public DateTime VarisSaati { get; set; }

        private int koltukKapasite = 42;
        public int KoltukKapasite
        {
            get
            {
                return koltukKapasite;
            }
        }
        public List<Personel>? Personeller { get; set; }
        public List<Yolcu>? Yolcular { get; set; }
        public List<Koltuk> Koltuklar { get; set; } = new List<Koltuk>();
    }

}
