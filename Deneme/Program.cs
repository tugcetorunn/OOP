class Program
{
    static void Main()
    {
        // String değişkenlerin referans tipi olduğunu göstermek için bir örnek
        // Stringler immutable olduğu için, bir string değiştiğinde aslında yeni bir string oluşturulur
        // Bu nedenle, string değişkenleri atandığında referansları değişir

        // Immutable: Değiştirilemez. Stringler immutable'dır, yani bir string değiştiğinde aslında yeni bir string oluşturulur.
        // String değişkenleri referans tipidir, yani bir string değişkeni başka bir string değişkenine atandığında, aslında iki değişken de aynı nesneyi referans eder.
        // Ancak, string değiştiğinde yeni bir nesne oluşturulur ve referans değişir.
        // Bu nedenle, string değişkenleri atandığında referansları değişir.
        // String değişkenleri immutable olduğu için, bir string değiştiğinde aslında yeni bir string oluşturulur
        // Bu nedenle, string değişkenleri atandığında referansları değişir.

        string a = "Merhaba";
        string b = a;  // b, a'nın referansını alır (şu anda aynı nesneye bakıyor)

        Console.WriteLine("Başlangıçta:");
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");

        b = "Selam"; // Yeni bir string atadık, çünkü string immutable olduğu için yeni referans oluşur

        Console.WriteLine("\nDeğişiklikten sonra:");
        Console.WriteLine($"a: {a}");  // Değişmedi
        Console.WriteLine($"b: {b}");  // Yeni string oldu

        // Referans tipi olduğunu daha net görmek için Object.ReferenceEquals kullanalım:
        string c = "Deneme";
        string d = c;
        Console.WriteLine($"\nc ve d aynı referansa mı bakıyor? {Object.ReferenceEquals(c, d)}");

        d = d + "!"; // Yeni string oluşur
        Console.WriteLine($"c ve d artık aynı referansa mı? {Object.ReferenceEquals(c, d)}");
        Console.ReadLine();

        ///////////////////////////////////////////////////////////////////////////////////////////////

        Kisi k1 = new Kisi { Ad = "Ahmet" };
        Kisi k2 = k1; // Aynı nesneyi gösteriyorlar

        k2.Ad = "Mehmet";

        Console.WriteLine(k1.Ad); // "Mehmet" — çünkü k1 ve k2 aynı nesneyi refer ediyor

    }
}

public class Kisi
{
    public string Ad { get; set; }
}

    

