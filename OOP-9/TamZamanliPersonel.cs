using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class TamZamanliPersonel : Personel
    {
        public TamZamanliPersonel(double taban) : base(taban)
        {
            MaasTabanUcreti = taban;
        }
        public double MaasTabanUcreti { get; set; }

    }
}
