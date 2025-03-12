using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class Personel : Person
    {
        public double Salary { get; set; }

        public override string GetInformation()
        {
            return $"{GeneralInformation} - {Salary}";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Salary}";
        }
    }
}
