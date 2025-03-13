using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal interface IKirilabilir
    {
        Durum Durum { get; set; }
        void ListedenCikar(IKirilabilir kirilabilirUrun);
    }
}
