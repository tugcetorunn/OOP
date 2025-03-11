// bir firmada tam zamanlı ve yarı zamanlı olmak üzere iki çeşit satış elemanı çalışmaktadır.
// tam zamanlı çalışan personellerin maaşı taban ücret + prim şeklinde hesaplanmaktadır.
// prim ise yaptığı aylık satış tutarı üzerinden;
// 250000 < %1
// 250000 >= < 500000 %2
// 500000 > %3 olarak hesaplanacaktır.

// yarı zamanlı personellerin maaşı ise çalıştığı (saat * saat ücreti) + prim şeklinde hesaplanacaktır.
// prim ise satışın sadece %1 idir.

using OOP_9;

TamZamanliPersonel tamZamanli = new TamZamanliPersonel(30000)
{
    Id = 1,
    Ad = "ali",
    Soyad = "veli",
    YapilanSatisTutari = 450000
};

YariZamanliPersonel yariZamanli = new YariZamanliPersonel(45, 200)
{
    Id = 1,
    Ad = "ali",
    Soyad = "veli",
    YapilanSatisTutari = 550000
};

tamZamanli.Maas = tamZamanli.TamZamanliMaasHesapla();
yariZamanli.Maas = yariZamanli.YariZamanliMaasHesapla();

Console.WriteLine($"Maas: {tamZamanli.Maas}"); // string interpolation
Console.WriteLine(yariZamanli.Maas);
Console.WriteLine();

