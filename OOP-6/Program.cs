// daire, silindir, koni nesnelerini oluşturunuz ve alan veya hacimlerini hesaplayınız.
// daire - pi.rkare
// silindir - pi.rkare.h
// koni - pi.rkare/3

using OOP_6;


Daire daire = new Daire() { Yaricap = 5 };
Console.WriteLine("Dairenin alanı : " + daire.DaireAlanHesapla());

Silindir silindir = new Silindir() { Yaricap = 10, Yukseklik = 12 };
Console.WriteLine("Silindirin alanı : " + silindir.SilindirAlanHesapla());

Koni koni = new Koni() { Yaricap = 10 };
Console.WriteLine("Koninin alanı : " + koni.KoniAlanHesapla());

Console.WriteLine();