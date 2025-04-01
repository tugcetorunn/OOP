using OOP_52_OtobusOOP.Abstracts.Classes;

namespace OOP_52_OtobusOOP.Concretes.Classes.Bagajlar
{
    public class EvcilHayvan : Canli
    {
        public int KoltukId { get; set; }
        public string Cins { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Cins: " + Cins;
        }
    }
}