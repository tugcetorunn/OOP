namespace OOP_49_HastaneOtomasyonSistemi.Concretes.Classes
{
    public class Bilesen
    {
        public int BilesenId { get; set; }
        public string BilesenAdi { get; set; }
        public List<Ilac>? Ilaclar { get; set; }
    }
}