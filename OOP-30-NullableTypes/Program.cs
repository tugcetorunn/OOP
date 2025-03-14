// nullable types lar neden çıkmıştır?
// sql de işaretlemezsek tüm kolonlar nullable olabiliyorken db yi c# a bağladığımızda value type ların null olmayacağı kısıtından dolayı çıkmıştır
// null değerlerin kontrolü için çıkmıştır. null değerlerin kontrolü için kullanılır.
// null değer alamayan veri tiplerinin null olabilmesini sağlar.
// nullable types aslında generic bir structtır.


int? sayi = null; // value types null olamaz.
Nullable<int> sayi2 = null; // nullable where t : struct kısıtlıdır. çünkü value type larda kullanılır.

int value = sayi.Value; // null değilse değeri döndürür. null ise hata verir.
bool nullMi = sayi.HasValue; // null değilse true döndürür. null ise false döndürür.

Console.WriteLine(sayi2.GetValueOrDefault()); // null cevabı almamak için kullanılır. null ise 0 döndürür.

Console.WriteLine(sayi ?? -1); // null kontrolü -> ? ne elvis operatörü denir.


