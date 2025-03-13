using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_18
{
    internal interface IArayuz
    {
        void Islem();
        string Test()
        {
            return "Arayüz içinde gövdeli yapılar da olur.";
        } // çok özel durumlarda kullanılır. abstract lığı etkiler. implemente eden sınıfların hepsinde bu metot böyle çalışmak zorunda olur. bunlara sadece interface intsance ı üzerinden ulaşırız.
    }
}
