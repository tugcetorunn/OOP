using OOP_52_OtobusOOP.Abstracts.Classes;
using OOP_52_OtobusOOP.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_52_OtobusOOP.Concretes.Classes.Calisanlar
{
    public class Muavin : Calisan, ISoforKoltugunaOturabilir
    {
        public string EhliyetNo { get; set; }
    }
}
