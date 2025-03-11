using OOP_3;

Personel personel = new Personel();

Musteri musteri = new() { Id = 1, Ad = "", Soyad = ""}; // C# 3.0 ile object initializer özelliği eklendi.
Musteri musteri2 = new Musteri { Id = 1, Ad = "", Soyad = ""}; 
Musteri musteri3 = new Musteri() { Id = 1, Ad = "", Soyad = ""}; 

Urun urun = new Urun() { UrunId = 1, UrunAdi = "", Fiyat = 1.2};
