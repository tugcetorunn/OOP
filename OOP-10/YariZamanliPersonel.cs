using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10
{
    internal class YariZamanliPersonel : Personel
    {
        public int CalismaSaati { get; set; }
        public double SaatUcreti { get; set; }

        public override double Prim => SatisTutari * 0.01;

        public override double Maas => (CalismaSaati * SaatUcreti) + Prim;
    }
}
