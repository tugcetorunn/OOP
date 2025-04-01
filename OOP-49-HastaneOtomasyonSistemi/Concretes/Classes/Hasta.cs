using OOP_49_HastaneOtomasyonSistemi.Abstracts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_49_HastaneOtomasyonSistemi.Concretes.Classes
{
    public class Hasta : Kisi
    {
        public List<Randevu>? Randevular { get; set; }
        public bool SigortaVarMi { get; set; }
    }
}
