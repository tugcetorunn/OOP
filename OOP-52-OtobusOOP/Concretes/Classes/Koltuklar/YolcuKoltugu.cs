using OOP_52_OtobusOOP.Abstracts.Classes;

namespace OOP_52_OtobusOOP.Concretes.Classes.Koltuklar
{
    public class YolcuKoltugu : Koltuk
    {
        public int KoltukId { get; set; }
        public Yolcu Yolcu { get; set; }
        public override string ToString()
        {
            return $"{KoltukId} - {Yolcu.ToString()}";
        }
    }
}