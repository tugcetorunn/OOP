using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_52_OtobusOOP.Abstracts.Classes
{
    public class Kisi : Canli
    {
        public string Soyad { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Soyad}";
        }
    }
}
