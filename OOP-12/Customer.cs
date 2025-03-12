using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class Customer : Person
    {
        public CariDurum CariDurum { get; set; }
        public override string GetInformation()
        {
            return $"{GeneralInformation} - {CariDurum}";
        }

        public override string ToString()
        {
            return base.ToString() + $"{CariDurum}";
        }
    }
}
