using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29_GenericKisitlar
{
    internal class MuhasebeIslemleri<T> where T : Personel, new() // birden fazla veriyi argument olarak verebilmeye yarar. new() rn sonda olması gerek.
                                                               // bu şekilde birden fazla kısıt olmak zorundadır.
                                                               // new() varsayılan const olup olmadığını kontrol eder. parametreli const var eğer varsayılan olmayabilir. bu sefer hata verir.
    {
    }
}
