using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_43_Delegates
{
    internal class Test
    {
        public static void Yaz()
        {
            Console.WriteLine("Yaz metodu");
        }

        public static void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }

        public static void Hello()
        {
            Console.WriteLine("hi there");
        }

        public static int KareAl(int sayi)
        {
            return sayi * sayi;
        }

        public static void KupAl(int sayi)
        {
            Console.WriteLine(sayi * sayi * sayi);
        }
    }
}
