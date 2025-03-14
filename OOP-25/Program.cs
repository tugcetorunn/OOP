// recursive metod - bir metotun kendi kendini çağırmasıdır.
// recursive metodları nerede kullanabiliriz?
// ne kadar çalışacağını bilmediğimiz fakat süreklilik arz eden işlemlerde kullanabiliriz.
// örneğin; bir dosya sistemindeki tüm dosyaları listelemek için kullanabiliriz.
// kesişimli çizgiler arasındaki alanı bulmak için kullanabiliriz. piksel piksel giderek alanı hesaplar çizgilere varana kadar.
// bir sayının faktöriyelini hesaplamak için kullanabiliriz.
// bir sayının asal olup olmadığını kontrol etmek için kullanabiliriz.
// bir sayının tersini almak için kullanabiliriz.
// bir sayının rakamlarının toplamını almak için kullanabiliriz.

int Faktoriyel(int sayi)
{
    //if (sayi == 1)
    //{
    //    return 1;
    //}
    return sayi * Faktoriyel(sayi - 1); // sadece bu satır olursa stackoverflow hatası (stack in taşması) alırız. yani sonuç dönmez. çünkü int in min değeri olan -2.147.483.648 ye kadar gider. bu yüzden if bloğu eklememiz gerekiyor. nereye kadar çalışacağını belirtmemiz gerekiyor.
}

Console.WriteLine(Faktoriyel(5));
Console.WriteLine();
