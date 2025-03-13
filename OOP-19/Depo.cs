using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    internal class Depo : IEnumerable
    {
        List<string> urunler = new List<string> { "defter", "kalem", "silgi"};

        public IEnumerator GetEnumerator()
        {
            return urunler.GetEnumerator(); // GetEnumerator metodu hazır geldiği için bu şekilde kullanabiliyoruz. bu metod list class ı içindedir.
        }
    }
}
