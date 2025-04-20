using OtobusOtomasyonSistemi.AbstractClasses;
using OtobusOtomasyonSistemi.Classes;

Random random = new Random();
List<string> listIsim = new List<string>() { "Ali", "Buse", "Esra", "Gökçe" };
List<string> listSoyisim = new List<string>() { "Kaya", "Han", "Kar", "Tan" };

Console.WriteLine("İşlem seçiniz");
Console.WriteLine("1 - Otobüs oluştur");
Console.WriteLine("2 - Otobüsü listele");
Console.WriteLine("3 - Otobüs verilerini dosyaya yazdır");

string secim = Console.ReadLine();

switch (secim)
{
	case "1":
		OtobusOlustur();
		break;
		
	case "2":

		break;

	case "3":
		break;

	default:
        Console.WriteLine("Geçerli seçim giriniz");
		break;
}

List<Personel> personeller = new List<Personel>()
    {
        new Sofor(){ Id = 1, KisiAdi = "Hasan", KisiSoyadi = "Taş", EhliyetNo = "12345", TecrubeYili = 15 },
        new Sofor(){ Id = 2, KisiAdi = "Hakan", KisiSoyadi = "Baş", EhliyetNo = "12347", TecrubeYili = 18 },
        new Muavin(){ Id = 3, KisiAdi = "Burak", KisiSoyadi = "Yaş", EhliyetNo = "12355", TecrubeYili = 2 },
        new HostHostes(){ Id = 4, KisiAdi = "Baran", KisiSoyadi = "Kaş", TecrubeYili = 3 }
    };
void OtobusOlustur()
{
	Otobus otobus = new Otobus()
	{
		Id = 1,
		Plaka = "16 S 1645",
		KalkisSaati = DateTime.Now.AddHours(-10),
		VarisSaati = DateTime.Now.AddHours(-1)
	};

	List<string> sehirler = new() { "İstanbul", "Kocaeli", "Yalova", "Bursa", "Balıkesir", "İzmir", "Manisa"};

	otobus.KalkisLokasyon = sehirler[0];
	otobus.KalkisLokasyon = sehirler[sehirler.Count - 1];
	otobus.AraLokasyonlar = sehirler;

	List<Yolcu> yolcular = new();
	otobus.Yolcular = yolcular;
	double? toplamBagaj = 0;


	for (int i = 0; i < random.Next(1, otobus.KoltukKapasite + 1); i++)
	{
		Yolcu yolcu = new Yolcu()
		{
			Id = i + 1,
			KisiAdi = listIsim[random.Next(listIsim.Count)],
			KisiSoyadi = listIsim[random.Next(listIsim.Count)],
			BagajKg = random.Next(0, 21),
			InecegiLokasyon = sehirler[random.Next(sehirler.Count - 2)]
		};

        yolcular.Add(yolcu);
		toplamBagaj += yolcu.BagajKg;

		if (yolcu.bagajFazlaMi(yolcu.BagajKg) == true)
		{
			yolcu.BagajKg = 20;
		}
	}
}

void PersonelEkle(Otobus otobus, List<Personel> personeller)
{
    otobus.Personeller = personeller;
}