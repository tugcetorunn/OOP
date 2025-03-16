using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_34_CalisanPuantajTakip.BaseAbstracts
{
    internal class Calisan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public double Mesai { get; set; }
        public Departman Departman { get; set; }
        public Pozisyon Pozisyon { get; set; }

        List<Puantaj> puantajlar = new List<Puantaj>();
        public List<Puantaj> Puantajlar => puantajlar;

        public override string ToString()
        {
            return $"{Id} - {Ad} {Soyad} - {Departman} {Pozisyon}";
        }
    }
}
