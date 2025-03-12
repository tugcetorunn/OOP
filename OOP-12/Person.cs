using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private protected string GeneralInformation 
        { 
            get 
            {
                return $"{Id} - {Name} - {Surname}"; // bu yazılmadan alt class larda base den de çağrılabilirdi.
            } 
        }

        public virtual string GetInformation()
        {
            return GeneralInformation;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Surname}";
        }

        // c# ta zaten string bir mesaj için tostring virtual metod hazır vardır onu kullanmak daha best practice dir.
        // open ?, closed modification
    }
}
