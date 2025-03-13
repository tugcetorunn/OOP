using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_21
{
    internal class Arac
    {
        public Arac() 
        {
            Renk = (ConsoleColor)new Random().Next(1, 16);
        }
        public int Id { get; set; }
        public ConsoleColor Renk { get; set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
