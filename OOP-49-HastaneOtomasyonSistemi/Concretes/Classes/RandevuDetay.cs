namespace OOP_49_HastaneOtomasyonSistemi.Concretes.Classes
{
    public class RandevuDetay
    {
        public int RandevuDetayId { get; set; }
        public Recete? Recete { get; set; }
        public string Rapor { get; set; }
        public double Ucret { get; set; }
    }
}