using OOP_24;
using OOP_24.Abstracts;

Market market = new Market();
int secim;

Yumurta yumurta = new Yumurta { Id = 7, Ad = "15li organik yumurta", Fiyat = 110, KirikMi = false, SKT = DateTime.Now.AddDays(16) };
SiseSut siseSut = new SiseSut { Id = 8, Ad = "1 kg günlük süt", Fiyat = 60, SKT = DateTime.Now.AddDays(-2), KirikMi = true };

do
{
    Console.WriteLine("1- Ürün Ekle");
    Console.WriteLine("2- Ürün Silme");
    Console.WriteLine("3- Ürün Listesi");
    Console.WriteLine("4- Bozuk Ürün Listesi");
    Console.WriteLine("5- Kırık Ürün Listesi");
    Console.WriteLine("6- Tarihi Geçmiş Ürün Listesi");
    Console.WriteLine("7- Çıkış");

    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            BaslangicUrunEkle(market);
            market.UrunEkle(yumurta);
            market.UrunEkle(siseSut);
            break;
        case 2:
            market.UrunCikar(siseSut);
            market.UrunCikar(yumurta);
            break;
        case 3:
            Yazdir(market.Urunler);
            break;
        case 4:
            Yazdir(market.BozukUrunler());
            break;
        case 5:
            Yazdir(market.KirikUrunler());
            break;
        case 6:
            Yazdir(market.TarihiGecmisUrunler());
            break;
        default:
            Console.WriteLine("1-7 arası değer giriniz!!!");
            break;
    }

} while (secim != 7);

void BaslangicUrunEkle(Market market)
{
    market.UrunEkle(new Bardak { Id = 1, Ad = "6lı su bardağı", Fiyat = 80, KirikMi = true });
    market.UrunEkle(new Bardak { Id = 2, Ad = "6lı meşrubat bardağı", Fiyat = 180, KirikMi = false });
    market.UrunEkle(new Bardak { Id = 3, Ad = "12li su bardağı", Fiyat = 120, KirikMi = false });
    market.UrunEkle(new Bardak { Id = 4, Ad = "6lı çay bardağı", Fiyat = 100, KirikMi = true });
    market.UrunEkle(new Yumurta { Id = 5, Ad = "6lı köy yumurtası", Fiyat = 70, KirikMi = true, SKT = DateTime.Now.AddDays(-6) });
    market.UrunEkle(new Yumurta { Id = 6, Ad = "10lu köy yumurtası", Fiyat = 80, KirikMi = false, SKT = DateTime.Now.AddDays(-6) });
    market.UrunEkle(new Yumurta { Id = 7, Ad = "15li organik yumurta", Fiyat = 110, KirikMi = false, SKT = DateTime.Now.AddDays(16) });
    market.UrunEkle(new SiseSut { Id = 8, Ad = "1 kg günlük süt", Fiyat = 60, SKT = DateTime.Now.AddDays(-2), KirikMi = false });
    market.UrunEkle(new SiseSut { Id = 9, Ad = "1 kg günlük süt", Fiyat = 70, SKT = DateTime.Now.AddDays(16), KirikMi = true });
    market.UrunEkle(new Bulgur { Id = 10, Ad = "1 kg ince bulgur", Fiyat = 55, TET = DateTime.Now.AddDays(96) });
    market.UrunEkle(new Bulgur { Id = 11, Ad = "1 kg pilavlık bulgur", Fiyat = 110, TET = DateTime.Now.AddDays(56) });
    market.UrunEkle(new KagitHavlu { Id = 12, Ad = "32li 2 katlı kağıt havlu", Fiyat = 140 });
}

void Yazdir(IEnumerable<Urun> urunler)
{
    Console.WriteLine();
    Console.WriteLine("--------------------------");
    foreach (var urun in urunler)
        Console.WriteLine(urun);
    Console.WriteLine();
}