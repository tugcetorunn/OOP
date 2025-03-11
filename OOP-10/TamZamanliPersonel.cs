using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10
{
    internal class TamZamanliPersonel : Personel
    {
        public double TabanUcreti { get; set; }
        public override double Prim
        {
            get
            {
                double prim;
                if (SatisTutari > 500000)
                {
                    prim = (SatisTutari * 0.03) + TabanUcreti;
                }
                else if (SatisTutari >= 250000 && SatisTutari < 500000)
                {
                    prim = (SatisTutari * 0.02) + TabanUcreti;
                }
                else if (SatisTutari < 250000)
                {
                    prim = (SatisTutari * 0.01) + TabanUcreti;
                }
                else
                {
                    prim = 0;
                }

                return prim;
            }
        }

        public override double Maas => TabanUcreti + Prim;
    }
}
