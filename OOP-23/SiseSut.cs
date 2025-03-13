using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23
{
    internal class SiseSut : Urun, ISKTGecerli
    {
        public DateTime SKT { get; set; }
        public Durum Durum 
        { 
            get
            {
                Durum durum;
                if (DateTime.Now > SKT)
                {
                    durum = Durum.Bozuk;
                    return durum;
                }
                else
                {
                    durum = Durum.Duzgun;
                    return durum;
                }
            }
            set;
        }

        public void ListedenCikar(ISKTGecerli bozulabilirUrun)
        {
            base.Market.UrunCikar(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"{Durum} + SKT : {SKT}";
        }
    }
}
