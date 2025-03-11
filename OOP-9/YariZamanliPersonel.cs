using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class YariZamanliPersonel : Personel
    {
        public YariZamanliPersonel(int saat, double saatUcreti) : base(saat, saatUcreti)
        {
            CalismaSaati = saat;
            SaatUcreti = saatUcreti;
        }
        public int CalismaSaati { get; set; }
        public double SaatUcreti { get; set; }
    }
}
