using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    internal class CamasirMakinesi : BaseClass
    {
        public int DevirKapasitesi { get; set; }
        public int KgKapasitesi { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Devir : {DevirKapasitesi} - Kg : {KgKapasitesi}";
        }
    }
}
