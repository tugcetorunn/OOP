using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13
{
    internal class Daire
    {
        public double Yaricap { get; set; }
        public virtual double Hesapla()
        {
            return double.Pi * Math.Sqrt(Yaricap); // alan
        }
    }
}
