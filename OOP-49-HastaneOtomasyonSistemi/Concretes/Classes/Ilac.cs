namespace OOP_49_HastaneOtomasyonSistemi.Concretes.Classes
{
    public class Ilac
    {
        public int IlacId { get; set; }
        public string IlacAdi { get; set; }
        public List<Bilesen>? Bilesenler { get; set; }
    }
}