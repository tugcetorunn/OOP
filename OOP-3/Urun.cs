using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Urun(int id, string ad, double fiyat)
    {
        public Urun() : this(0, "", 0) { } // public Urun() : this(0, 0) { }

        public int UrunId { get; set; } = id;
        public string UrunAdi { get; set; } = ad;
        public double Fiyat { get; set; } = fiyat;
    }
}
