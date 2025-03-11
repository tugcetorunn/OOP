using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Personel
    {
        public Personel()
        {
            
        }
        public Personel(int id)
        {
            PersonelId = id;
        }

        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
