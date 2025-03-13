using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_22_InterfaceSegregation
{
    internal class Devekusu : ICanli
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            // arayüzden gelen hiçbir yapı atıl kalamaz.
            // throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
