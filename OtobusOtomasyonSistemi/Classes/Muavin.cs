using OtobusOtomasyonSistemi.AbstractClasses;
using OtobusOtomasyonSistemi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSistemi.Classes
{
    public class Muavin : Personel, IEhliyet
    {
        public string EhliyetNo { get; set; }
    }
}
