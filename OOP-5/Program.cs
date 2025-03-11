using OOP_5;

// Personel personel = new Personel(); // newlenmez, abstract old için.

GiseMemuru giseMemuru = new GiseMemuru();

// PersonelIslemleri personelIslemleri = new PersonelIslemleri(); // newlenmez, static old için.

Market market = new Market();
// market. dediğimizde urunEkle metoduna erişemiyoruz. neden? çünkü bu instance. direk class ı kullanmamız gerek static metoda ulaşmak için

Market.UrunEkle();

// Enumerable.Select();

// daire, silindir, koni nesnelerini oluşturunuz ve alan veya hacimlerini hesaplayınız.
// daire - pi.rkare
// silindir - pi.rkare.h
// koni - pi.rkare/3