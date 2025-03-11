using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class Personel
    {
        public Personel(int saat, double saatUcreti)
        {
            CalismaSaati = saat;
            SaatUcreti = saatUcreti;
        }
        public Personel(double taban)
        {
            TabanUcreti = taban;
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int YapilanSatisTutari { get; set; }
        public double Prim { get; set; }
        public double Maas { get; set; }
        private double TabanUcreti { get; set; }
        private int CalismaSaati { get; set; }
        private double SaatUcreti { get; set; }

        public double TamZamanliMaasHesapla()
        {
            if (YapilanSatisTutari > 500000)
            {
                Maas = (YapilanSatisTutari * 0.03) + TabanUcreti;
            }
            else if (YapilanSatisTutari >= 250000 && YapilanSatisTutari < 500000)
            {
                Maas = (YapilanSatisTutari * 0.02) + TabanUcreti;
            }
            else
            {
                Maas = (YapilanSatisTutari * 0.01) + TabanUcreti;
            }

            return Maas;
        }

        public double YariZamanliMaasHesapla()
        {
            Prim = YapilanSatisTutari * 0.01;
            Maas = (CalismaSaati * SaatUcreti) + Prim;

            return Maas;
        }
    }
}
