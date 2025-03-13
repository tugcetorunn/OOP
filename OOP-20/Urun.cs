using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20
{
    internal class Urun : IComparable
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object? other)
        {
            Urun urun = other as Urun;
            return this.Fiyat.CompareTo(urun.Fiyat);
        }
        public override string ToString()
        {
            return $"{Id} - {Ad} - {Fiyat}";
        }

    }
}
