using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_27_Generic
{
    internal class Depo<T>
    {
        public void Ekle(T eleman)
        {
            //T[] tempArray = dizi;
            //dizi = new T[dizi.Length + 1];
            //for (int i = 0; i < tempArray.Length; i++)
            //{
            //    dizi[i] = tempArray[i];
            //}
            //dizi[dizi.Length - 1] = eleman;
        }

        public List<T> Listele()
        {
            return new List<T>();
        }
    }
}
