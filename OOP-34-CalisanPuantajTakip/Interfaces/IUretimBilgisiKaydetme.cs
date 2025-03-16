using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_34_CalisanPuantajTakip.Interfaces
{
    internal interface IUretimBilgisiKaydetme
    {
        void UretimRaporOlustur(DateTime gun, int urunId, int adet);
    }
}
