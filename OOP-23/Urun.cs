using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public Market Market { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Ad} - {Fiyat}";
        }

    }
}
