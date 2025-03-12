using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13
{
    internal class Koni : Silindir
    {
        public override double Hesapla()
        {
            return base.Hesapla() / 3; // hacim
        }
    }
}
