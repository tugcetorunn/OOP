using OOP_11;

Araba araba = new Araba();
Ferrari ferrari = new Ferrari();
Serce serce = new Serce();

araba.Sur();
ferrari.Sur();
serce.Sur();

Console.WriteLine("----------------");

Araba araba2 = new Araba();
Araba ferrari2 = new Ferrari(); // aslında içinde hem base deki metod hem kendi metodu var ama araba tanımlandığı için ve polymorphism olmadığı için arabanınki çalışıyor.
Araba serce2 = new Serce(); // serçe üretiliyor fakat referansı araba tipinde tutuluyor. yani stack te Araba serce2, heap te Serce nesnesi oluşuyor. (cast ile içerideki (serce) tipe ulaşılır. unboxing?)

// problem ne? neden araba olarak tanımladık -> collection da tutarken hepsini işin içine katacağımız zaman base tipinde alıyoruz. class member lar polymorphisme uygun değilse base deki class memberları alır.

araba2.Sur();
ferrari2.Sur();
serce2.Sur();

Console.ReadLine();
