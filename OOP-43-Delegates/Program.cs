// string str;
// str.Where(); // public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) (func ister)

using OOP_43_Delegates;

Temsilci temsilci = new Temsilci(Test.Yaz);

temsilci += Test.Merhaba;
temsilci += Test.Hello;
temsilci += Test.Hello;
temsilci -= Test.Hello;
// temsilci. -> BEGININVOKE, ENDINVOKE, GETINVOCATIONLIST, COMBINE, REMOVE

// temsilci += Test.KareAl; // return ve imza uymuyor
// temsilci += Test.KupAl; // imza uymuyor

temsilci(); // direk metodu kullanmıyoruz. delege üzerinden kullanıyoruz.

// multicast delegates
foreach(Delegate @delegate in temsilci.GetInvocationList())
{
    Console.WriteLine(@delegate.Method.Name);
	if (@delegate.Method.Name == "Yaz")
	{
        Console.WriteLine("Dinamik çağır...");
		@delegate.DynamicInvoke(); // bağlanmış olan metodu tetikler otomatik olarak çağlıştırır.
	}
}

// anonim metod

var t = delegate ()
{
	Console.WriteLine("action tipinde (void geri döndürdüğü için) oluşan anonim metod");
};

t();

Console.WriteLine();

public delegate void Temsilci(); // main olmadığı için altta bulunması gerekiyor.

