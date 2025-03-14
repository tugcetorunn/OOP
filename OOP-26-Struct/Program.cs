using OOP_26_Struct;

int sayi;
double ondalik = new double();
bool dogruMu;
char karakter = new char();
// value type olan yapılar struct tır. struct lar stack te tutulur.
// value type ların en büyük özelliği boyutları sabittir. yani stack te tutulurlar ve stack in boyutu sabittir. stack in boyutu 1 mb dır. bu yüzden stack ta tutulan veri boyutu 1 mb yi geçmemelidir. 16 byte ?

Nokta nokta = new Nokta();
nokta.X = 12;
nokta.Y = 13;

Console.WriteLine(nokta.Koordinat());

// Console.WriteLine(sayi); c# da değişkenlerin değerleri kullanılmadan önce atanmalıdır (value type larda). aksi takdirde hata alırız.
Console.WriteLine(ondalik); // struct ları new lediğimizde otomatik default değer atar.
Console.WriteLine((int)karakter); // char default boşluk getirir. cast ettiğimizde ascii karakter kodu olarak 0 döner. fakat alt+0 bir şey getrmiyor. 

Console.WriteLine();

