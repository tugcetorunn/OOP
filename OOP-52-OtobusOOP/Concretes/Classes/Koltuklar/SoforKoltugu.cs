using OOP_52_OtobusOOP.Abstracts.Classes;
using OOP_52_OtobusOOP.Abstracts.Interfaces;
using OOP_52_OtobusOOP.Concretes.Classes.Calisanlar;

namespace OOP_52_OtobusOOP.Concretes.Classes.Koltuklar
{
    public class SoforKoltugu : Koltuk
    {
        public IAracKullanabilir Sofor { get; set; }
    }
}