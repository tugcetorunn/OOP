// bir market için uygulama yazınız.
// market; yumurta(skt), şişe süt(skt), bulgur(tet), kağıt havlu, bardak ürünlerini satmaktadır.
// ürün -> id, ad, fiyat
// ürün ekleme, ürün silme
// raporlar
// - tüm ürünlerin listesi
// - bozuk ürünlerin listesi
// - kırık ürünlerin listesi
// - kullanma tarihi geçmiş ürünlerin listesi

using OOP_23;


Console.WriteLine("İşlem seçin : ");
Console.WriteLine("1- Ürün Ekle");
Console.WriteLine("2- Ürün Silme");
Console.WriteLine("3- Ürün Listesi");
Console.WriteLine("4- Bozuk Ürün Listesi");
Console.WriteLine("5- Kırık Ürün Listesi");
Console.WriteLine("6- Tarihi Geçmiş Ürün Listesi");

int secim = int.Parse(Console.ReadLine());
switch (secim)
{
    case 1:
        Console.WriteLine("Id : ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Tip : ");
        string tip = Console.ReadLine();
        Console.WriteLine("Ad : ");
        string ad = Console.ReadLine();
        Console.WriteLine("Fiyat : ");
        double fiyat = double.Parse(Console.ReadLine());
        Console.WriteLine("SKT varsa giriniz : ");
        if (Console.ReadLine() != null)
        {
            DateTime skt = DateTime.Parse(Console.ReadLine());
            Market market4 = new Market();
            market4.UrunEkle(new Urun { Id = id, Ad = ad, Fiyat = fiyat });
        }
        else
        {
            Console.WriteLine("TET varsa giriniz : ");

            if (Console.ReadLine() != null)
            {
                DateTime skt = DateTime.Parse(Console.ReadLine());
                Market market5 = new Market();
                market5.UrunEkle(new Urun { Id = id, Ad = ad, Fiyat = fiyat });
            }
            else
            {
                Market market1 = new Market();
                market1.UrunEkle(new Urun { Id = id, Ad = ad, Fiyat = fiyat });
            }
        }

        Market market = new Market();
        market.UrunEkle(new Urun { Id = id, Ad = ad, Fiyat = fiyat});
        break;
    case 2:
        Console.WriteLine("Hangi ürün (id) : ");
        int id2 = int.Parse(Console.ReadLine());
        Market market2 = new Market();
        market2.UrunCikar(id2);
        break;
    case 3:
        Market market3 = new Market();
        foreach (var urun in market3.Urunler)
        {
            Console.WriteLine(urun.ToString());
        }
        break;
    case 4:

        break;
    case 5:
        break;
    case 6:
        break;
    default:
		break;
}
