using OOP_20;

List<int> sayilar = new List<int> { 1, 2, 13, 24, 45, 16, 27, 48, 19, 10 };

sayilar.Sort(); // küçükten büyüğe sıralar.

foreach (var item in sayilar)
    Console.WriteLine(item);

Urun urun1 = new Urun() { Id = 1, Ad = "kalem", Fiyat = 60};
Urun urun2 = new Urun() { Id = 2, Ad = "silgi", Fiyat = 20};
Urun urun3 = new Urun() { Id = 3, Ad = "defter", Fiyat = 150};

List<Urun> urunler  = new List<Urun>() { urun1, urun2, urun3};

urunler.Sort(); // küçükten büyüğe sıralar.

foreach (var urun in urunler)
{
    Console.WriteLine(urun);
}

Console.WriteLine();

