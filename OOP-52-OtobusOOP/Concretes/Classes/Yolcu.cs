using OOP_52_OtobusOOP.Abstracts.Classes;
using OOP_52_OtobusOOP.Concretes.Classes.Bagajlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_52_OtobusOOP.Concretes.Classes
{
    public class Yolcu : Kisi
    {
        public string VarisYeri { get; set; }
        public Bagaj? Bagaj { get; set; }
        public EvcilHayvan? EvcilHayvan { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} - Varış yeri: {VarisYeri} - Bagaj: {Bagaj.BagajAgirligi} kg - Evcil hayvan: {(EvcilHayvan) ?? EvcilHayvan: 'evcil hayvan yok'}";
        }
    }
}
