List<int> sayilar = new List<int> { 1, 2, 34, 78, 48, 45, 16, 27 };

// bildiğiniz yöntemleri kullanarak tek sayıları bulunuz.

// 1. yöntem

List<int> tekSayilar = new List<int>();

var t = delegate (List<int> sayiListesi)
{
    foreach (int sayi in sayiListesi)
    {
        if (sayi % 2 == 1)
        {
            Console.WriteLine($"{sayi} tektir.");
        }
    }
};

t(sayilar);

// 2. yöntem

tekSayilar.AddRange(sayilar.Where(sayi => sayi % 2 == 1));
foreach (var item in tekSayilar)
{
    Console.WriteLine(item);
}

// sayilar.FindAll() predicate parametre istiyor (delegate) predicate bool dönüyor t istiyor.

// 3. yöntem

Predicate<int> predicate = new Predicate<int>(SayiTekMi);

Yazdir(sayilar.FindAll(predicate));

bool SayiTekMi(int sayi)
{
    return sayi % 2 == 1;
}

void Yazdir(IEnumerable<int> sayilar)
{
    foreach (var sayi in sayilar)
    {
        Console.Write(sayi + " ");
    }
    Console.WriteLine();
}

// 4. yöntem

Yazdir(sayilar.FindAll(SayiTekMi)); // arkada kendi oluşturuyor.
// özet: delegate i tanımlayıp metod vermek zorunda değiliz. direk kullanacağımız yerde metodu çağırabiliriz.

// 5. yöntem

Yazdir(sayilar.FindAll(delegate (int sayi) { return sayi % 2 == 1; }));
// delegate gördüğüm herhangi bir yere anonim olarak da tanımlayabiliriz.

// 6. yöntem

Yazdir(sayilar.FindAll(x => x % 2 == 1));
// => lambda expression bize kısa yollu metod oluşturuyor. => gördüğümüz yerde orada metod vardır. c# 3.0 da geldi.

Console.WriteLine();




