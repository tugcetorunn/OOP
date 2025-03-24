using OtobusOtomasyonSistemi.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonSistemi.AbstractClasses
{
    public abstract class BaseKisi
    {
        public int Id { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSoyadi { get; set; }
        public Koltuk Koltuk { get; set; }
    }
}
