using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal class Silindir : Daire
    {
        public Silindir(double r, double h) : base(r)
        {
            Console.WriteLine("Silindir nesnesi oluştu...");
        }
    }
}
