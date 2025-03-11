using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class Kitap
    {
        public Kitap() 
        {
            
        }
        public Kitap(int id, string ad, string onsoz, string yazar)
        {
            Id = id;
            Ad = ad;
            Onsoz = onsoz;
            Yazar = yazar;
        }

        public Kitap(int id, string ad, string onsoz) : this(id, ad, onsoz, "")
        {

        }

        public Kitap(int id, string ad) : this(id, ad, "", "")
        {

        }

        public Kitap(string ad) : this(0, ad, "", "")
        {

        }

        //public Kitap(int id, string ad, string yazar)
        //{
        //    Id = id;
        //    Ad = ad;
        //    Yazar = yazar;
        //}

        //public Kitap(string ad, string yazar)
        //{
        //    Ad = ad;
        //    Yazar = yazar;
        //}

        //public Kitap(string ad, string onsoz, string yazar)
        //{
        //    Ad = ad;
        //    Onsoz = onsoz;
        //    Yazar = yazar;
        //}

        public int Id { get; set; } = 0;
        public string Ad { get; set; }
        public string Onsoz { get; set; }
        public string Yazar { get; set; }
    }
}
