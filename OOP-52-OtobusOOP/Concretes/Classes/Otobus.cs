using OOP_52_OtobusOOP.Abstracts.Classes;
using OOP_52_OtobusOOP.Concretes.Classes.Bagajlar;
using OOP_52_OtobusOOP.Concretes.Classes.Koltuklar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_52_OtobusOOP.Concretes.Classes
{
    public class Otobus
    {
        public Otobus(int yolcuKapasitesi)
        {
            YolcuKoltuklari = new List<YolcuKoltugu>(yolcuKapasitesi);
            SoforKoltugu = new SoforKoltugu();
            MuavinKoltugu = new MuavinKoltugu();
            Bagajlar = new List<Bagaj>();
            EvcilHayvanlar = new List<EvcilHayvan>(3);
            Calisanlar = new List<Calisan>();
        }
        public int OtobusId { get; set; }
        public string Plaka { get; set; }
        public List<YolcuKoltugu> YolcuKoltuklari { get; set; }
        public SoforKoltugu SoforKoltugu { get; set; }
        public MuavinKoltugu MuavinKoltugu { get; set; }
        public List<Calisan> Calisanlar { get; set; }
        public List<Bagaj> Bagajlar { get; set; }
        public List<EvcilHayvan> EvcilHayvanlar { get; set; }

    }
}
