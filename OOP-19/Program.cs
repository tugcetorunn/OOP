using OOP_19;
using System.Collections;

List<string> sehirler = new List<string> { "Bursa", "Ankara", "İstanbul", "İzmir" };

foreach (var item in sehirler)
    Console.WriteLine(item);

Console.WriteLine();

Depo depo = new Depo(); // depoya IEnumerable implemente edildiği için foreach ile erişebiliriz. Framework uyumlu hale getirildi.
foreach (var item in depo) // foreach collectionlarda bulunan getenumerator metodunu çağırır. bu metot IEnumerator döner. IEnumerator da Current, MoveNext, Reset metodları var. Current - o anki elemanı verir. MoveNext - bir sonraki elemana geçer. Reset - başa döner.
    Console.WriteLine(item); // source code lara bakarak c# framework teki hazır metodları kendi proje yapımıza uyarlayabilmemiz çok önemli ve işlev sağlayan bir iş. bu sayede framework ile uyumlu hale getirebiliriz. bu sayede foreach ile erişebiliriz. IEnumerable interface i implement edildiği için getenumerator metodundan faydalandık ve foreach ile erişilebilir hale getirdik. IEnumerator döner. 

IEnumerable values = new List<string> { "Bursa", "Ankara", "İstanbul", "İzmir" }; // IEnumerable -> IEnumerator -> Current, MoveNext, Reset -> foreach çalışma mekanizması - current iterasyon değişkenidir. sadece get metodu olan object tir.

foreach (var item in values)
{
    Console.WriteLine(item);
}

