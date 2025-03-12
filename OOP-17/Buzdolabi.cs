using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    internal class Buzdolabi : BaseClass
    {
        public bool NoFrostMu { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" NoFrostMu : {NoFrostMu}";
        }
    }
}
