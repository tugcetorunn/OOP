using OOP_13;

Daire daire = new Daire { Yaricap = 15 };
Silindir silindir = new Silindir { Yaricap = 25, Yukseklik = 18 };
Koni koni = new Koni { Yaricap = 8, Yukseklik = 14 };

Console.WriteLine($"Dairenin Alanı: {daire.Hesapla()}");
Console.WriteLine($"Silindirin Alanı: {silindir.Hesapla()}");
Console.WriteLine($"Koninin Alanı: {koni.Hesapla()}");
Console.WriteLine("");

