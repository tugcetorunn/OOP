// bir depo sınıfında;
// tv, buzdolabı,çamaşır mk. tutulmaktadır.
// tv -> id, marka, model, açıklama, fiyat
// buzdolabı -> id, marka, model, açıklama, fiyat, no-frost
// çamaşır mk. -> id, marka, model, açıklama, fiyat, devir sayısı, kapasite(kg)
// bu depoyu simule eden sınıfları oop ile yazınız
// raporlar;
// depodaki tüm ürünlerin listesi
// depodaki tüm ürünlerin toplam fiyatı

using OOP_17;

Depo depo = new Depo();

depo.UrunEkle(new Televizyon
{ Id = 1, Marka = "Samsung", Model = "458000qled", Aciklama = "4K QLED Smart TV", Fiyat = 25000, StokAdedi = 10 });
depo.UrunEkle(new Televizyon
{ Id = 2, Marka = "Toshiba", Model = "657000oled", Aciklama = "4K OLED Smart TV", Fiyat = 20000, StokAdedi = 20 });
depo.UrunEkle(new Televizyon
{ Id = 3, Marka = "LG", Model = "458000uhd", Aciklama = "4K UHD Smart TV", Fiyat = 15000, StokAdedi = 30 });
depo.UrunEkle(new Televizyon
{ Id = 3, Marka = "LG", Model = "458000uhd", Aciklama = "4K UHD Smart TV", Fiyat = 15000, StokAdedi = 30 });
depo.UrunEkle(new Televizyon
{ Id = 4, Marka = "Philips", Model = "451000hd", Aciklama = "HD TV", Fiyat = 5000, StokAdedi = 15 });
depo.UrunEkle(new Buzdolabi { Id = 5, Marka = "Beko", Model = "458000no-frost", Aciklama = "No-Frost Buzdolabı", Fiyat = 30000, StokAdedi = 25, NoFrostMu = true });
depo.UrunEkle(new Buzdolabi { Id = 6, Marka = "Bosch", Model = "658000", Aciklama = "Buzdolabı", Fiyat = 20000, StokAdedi = 15, NoFrostMu = false });
depo.UrunEkle(new Buzdolabi { Id = 7, Marka = "Bosch", Model = "408000no-frost", Aciklama = "No-Frost Buzdolabı", Fiyat = 35000, StokAdedi = 35, NoFrostMu = true });
depo.UrunEkle(new CamasirMakinesi { Id = 8, Marka = "Bosch", Model = "408000dvr", Aciklama = "2700 Çamaşır makinesi", DevirKapasitesi = 1200, KgKapasitesi = 9, Fiyat = 30000, StokAdedi = 35 });
depo.UrunEkle(new CamasirMakinesi { Id = 9, Marka = "LG", Model = "428000dvr", Aciklama = "2800 Çamaşır makinesi", DevirKapasitesi = 1000, KgKapasitesi = 10, Fiyat = 35000, StokAdedi = 25 });
depo.UrunEkle(new CamasirMakinesi { Id = 10, Marka = "Samsung", Model = "4012000dvr", Aciklama = "2900 Çamaşır makinesi", DevirKapasitesi = 1500, KgKapasitesi = 12, Fiyat = 40000, StokAdedi = 30 });

foreach (var urun in depo.TumUrunler())
{
    Console.WriteLine(urun);
}

Console.WriteLine("Toplam depo malzeme satış tutarı : " + depo.TumUrunlerinToplamFiyati);

Console.WriteLine();




