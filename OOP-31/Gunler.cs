using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_31
{
    internal enum Gunler : byte // numeric tarafın tipini değiştirebiliriz bu şekilde. default inttir. tamsayı olmalıdır, double kabul etmez. kalıtım değildir.
    {
        Pazartesi,
        Sali,
        Carsamba = 12,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}
