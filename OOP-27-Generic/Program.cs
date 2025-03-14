using OOP_27_Generic;

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void Yazdir(int[] dizi)
{
    foreach (var item in dizi)
    {
        Console.WriteLine(item);
    }
}

Yazdir(sayilar);

string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };

void YazdirStr(string[] dizi)
{
    foreach (var item in dizi)
    {
        Console.WriteLine(item);
    }
}

YazdirStr(sehirler);

void EkranaYazdir<T>(T[] dizi)
{
    foreach (var item in dizi)
    {
        Console.WriteLine(item);
    }
}

EkranaYazdir<int>(sayilar);
EkranaYazdir(sehirler);

// tanımladığımızda parametre denen elemanlara çağrılırken argument tir.

Depo<Televizyon> depo = new Depo<Televizyon>();
depo.Ekle(new Televizyon());

Depo<Buzdolabi> depo2 = new Depo<Buzdolabi>();
depo2.Ekle(new Buzdolabi());

Console.WriteLine();