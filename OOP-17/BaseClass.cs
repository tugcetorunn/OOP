using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    internal class BaseClass
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public int StokAdedi { get; set; }

        public override string ToString()
        {
            return $"Ürün tipi : {Aciklama} - Ürün markası : {Marka} - Ürün modeli : {Model} - Ürün fiyatı : {Fiyat} - Stok adedi : {StokAdedi}";
        }

    }
}
