using OOP_24.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_24.Abstracts
{
    internal class Bulgur : Urun, ITET
    {
        public DateTime TET { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {TET}";
        }
    }
}
