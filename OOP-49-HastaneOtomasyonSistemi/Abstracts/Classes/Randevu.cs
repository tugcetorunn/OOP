using OOP_49_HastaneOtomasyonSistemi.Concretes.Classes;

namespace OOP_49_HastaneOtomasyonSistemi.Abstracts.Classes
{
    public abstract class Randevu
    {
        public int RandevuId { get; set; }
        public Doktor? Doktor { get; set; }
        public Hasta? Hasta { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public RandevuDetay? RandevuDetay { get; set; }
        public Durum Durum { get; set; }

        public override string ToString()
        {
            return $"{RandevuId} - {Hasta} - {Doktor} - {RandevuTarihi}";
        }
    }
}