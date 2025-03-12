using System.Collections;

ArrayList arrayList = new ArrayList();
List<int> list = new List<int>();

DateTime basla, bitir; // new e gerek yok çünkü struct
TimeSpan delta = new TimeSpan();

int sayac = 999999;

// arraylist için

basla = DateTime.Now;

for (int i = 0; i < sayac; i++)
{
    arrayList.Add(i);
    int sayi = (int)arrayList[i];
}

bitir = DateTime.Now;

delta = bitir - basla;
Console.WriteLine($"ArrayList = {delta.TotalMilliseconds}");

// list için

basla = DateTime.Now;

for (int i = 0; i < sayac; i++)
{
    list.Add(i);
    int sayi = list[i];
}

bitir = DateTime.Now;

delta = bitir - basla;
Console.WriteLine($"List = {delta.TotalMilliseconds}");
Console.WriteLine();
// arraylist in oluşma süresi 150 küsür milisec ken list in 8 milisec çıkmıştır. aradaki farkın sebebi arraylist obje üretip içine int alırken boxing unboxing yapma işlem sürecinden dolayıdır.
// bu sebeple performansla ilgili sıkıntımız varsa list kullanmak daha iyidir. arraylist gerekmedikçe kullanmayız.