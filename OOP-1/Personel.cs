using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Personel
    {
        private int id; // class seviyesinde (bir de dll seviyesi var) default olarak private tır. varsayılan öyle olsa da private belirtmek clean code açısından iyidir. private old için instance ile erişemiyoruz.
        public int Id;
        
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        // daha sonra property ler çıktı. property lerin get ve set metodları vardır. property, full property ve auto property (c# 3.0 dan sonra) olmak üzere 3 çeşittir.

        public int Yas { get; set; } // auto property ihtiyacı olan değişkeni (field) kendi oluşturur. backingField oluşturur. PROPERTY LER ASLINDA GET SET YAPAN METOTLARDIR. bir aracıdır, kendi üzerinde veri tutmaz.

        public string Ad { get; set; } // auto property

        private string soyad; // c# 3.0 öncesi property (2008)
        public string Soyad // full property diye çıkıyor?
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }



    }
}
