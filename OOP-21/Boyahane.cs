using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_21
{
    internal class Boyahane : IAracBoyar
    {
        //public void AracBoya(ConsoleColor renkSecimi, Arac arac) 
        //{
        //    arac.Renk = renkSecimi;
        //}

        public void AracBoya(ConsoleColor renkSecimi, IBoyanabilir gelenArac)
        {
            Arac arac = gelenArac as Arac;
            EkranaGoster(arac, "Boyanmadan önce");
            arac.Renk = renkSecimi;
            EkranaGoster(arac, "Boyandıktan sonra");
        }

        private void EkranaGoster(Arac gelenArac, string mesaj)
        {
            Console.WriteLine(mesaj);
            Console.ForegroundColor = gelenArac.Renk;
            Console.WriteLine(gelenArac.ToString());
        }
    }
}
