using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_26_Struct
{
    internal struct Nokta
    {
        public int X { get; set; } 
        public int Y { get; set; } 
        public string Koordinat()
        {
            return $"N({X}, {Y})";
        }

    }
}
