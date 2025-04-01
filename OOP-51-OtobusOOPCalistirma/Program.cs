// şehirlerarası bir otobüs firması için bir oop uygulaması geliştirilecektir. firmanın tek tip otobüsleri vardır. her otobüs için;
// 40 yolcu + 2 şoför + 1 muavin + 1 host/hostes olmak üzere 4 personeli bulunmaktadır. 
// koltuk olarak ise 40 yolcu, 1 şoför ve 1 de şoför yanı koltuğu vardır. 
// şoför koltuğuna sadece ehliyeti olan personel oturabilir, şoför yanı koltuğuna ise sadece personel oturabilir.
// yolcular yanlarında max 20 kg bagaj alabilirler. ayrıca otobüslerde küçük boyutlu üç adet evcil hayvan için bagaj bulunmaktadır.
// personel ile ilgili ad, soyad, yaş, tecrübe (yıl cinsinden) bilgileri tutulacaktır.
// yolcular ile ilgili ad, soyad, gideceği lokasyon, bagaj (varsa), evcil hayvan (varsa)
// evcil hayvan ile ilgili ad, yaş, cins

// sadece tek otobüs için rastgele personelleri, yolcuları, ... oluşturunuz. 

// çalışma kısmı hariç tüm yapılar dll de tutulmalıdır.
// uygulama çalıştığında;
// 1- otobüsü oluştur.
// 2- otobüsü listele.
// 3- otobüsün verileri dosyaya json olarak yaz. (personel + yolcu)

using OOP_52_OtobusOOP.Abstracts.Classes;
using OOP_52_OtobusOOP.Concretes.Classes;
using OOP_52_OtobusOOP.Concretes.Classes.Koltuklar;
using OOP_52_OtobusOOP.Utilities;

Otobus otobus = new(40);

OtobusManager.OtobusOlustur(otobus);

foreach (var personel in otobus.Calisanlar)
{
    Console.WriteLine(personel.ToString());
}

Console.WriteLine("************************");

foreach (var koltuk in otobus.YolcuKoltuklari)
{
    Console.WriteLine(koltuk.Yolcu.ToString());
}

OtobusManager.DosyayaYaz<YolcuKoltugu>("koltuklar.json", otobus.YolcuKoltuklari);

Console.WriteLine();