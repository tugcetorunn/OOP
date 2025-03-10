using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Kitap
    {
        // 5 propertysi olan, bunlardan en az biri 3.0 öncesi property olan bir class oluşturunuz

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }

        private string isbNo;
        public string IsbNo
        {
            get
            {
                return isbNo;
            }
            set
            {
                isbNo = value;
            }
        }


    }
}
