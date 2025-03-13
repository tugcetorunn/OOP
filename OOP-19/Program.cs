using OOP_19;
using System.Collections;

List<string> sehirler = new List<string> { "Bursa", "Ankara", "İstanbul", "İzmir" };

foreach (var item in sehirler)
    Console.WriteLine(item);

Console.WriteLine();

Depo depo = new Depo(); // depoya IEnumerable implemente edildiği için foreach ile erişebiliriz. Framework uyumlu hale getirildi.
foreach (var item in depo)
    Console.WriteLine(item);

IEnumerable values = new List<string> { "Bursa", "Ankara", "İstanbul", "İzmir" }; // IEnumerable -> IEnumerator -> Current, MoveNext, Reset -> foreach çalışma mekanizması - current iterasyon değişkenidir. sadece get metodu olan object tir.


