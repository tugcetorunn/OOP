using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_49_HastaneOtomasyonSistemi.Abstracts.Classes
{
    public abstract class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas => DateTime.Now.Year - DogumTarihi.Year;

        public override string ToString()
        {
            return $"{Id} - {Ad} - {Soyad} - {TC} - {Yas}";
        }
    }
}
