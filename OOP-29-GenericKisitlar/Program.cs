// class, struct, inheritance, interface, new() generic kısıtlardır. birlikte de kullanılabilirler.

using OOP_29_GenericKisitlar;

// where T : class
Test<string> test = new Test<string>();
Test<object> test1 = new Test<object>();
Test<Urun> test3 = new Test<Urun>();

// Test<int> test2 = new Test<int>(); // int bir referans tip değildir, structtır. bu yüzden hata alırız.

// where T : struct
Islem<int> test4 = new Islem<int>();
Islem<bool> test5 = new Islem<bool>();
// Islem<Urun> test6 = new Islem<Urun>();

// where T : inheritance (personel)
PersonelIslemleri<Hizmetli> personelIslemleri = new PersonelIslemleri<Hizmetli>();
PersonelIslemleri<Mudur> personelIslemleri1 = new PersonelIslemleri<Mudur>();
// PersonelIslemleri<string> personelIslemleri2 = new PersonelIslemleri<string>();

// where T : interface
SilahRuhsatIslemleri<Mudur> silahRuhsatIslemleri = new SilahRuhsatIslemleri<Mudur>();
SilahRuhsatIslemleri<Guvenlik> silahRuhsatIslemleri1 = new SilahRuhsatIslemleri<Guvenlik>();
// SilahRuhsatIslemleri<Hizmetli> silahRuhsatIslemleri1 = new SilahRuhsatIslemleri<Hizmetli>();

// where T : new()
MuhasebeIslemleri<Mudur> muhasebeIslemleri = new MuhasebeIslemleri<Mudur>();
MuhasebeIslemleri<Memur> muhasebeIslemleri1 = new MuhasebeIslemleri<Memur>();
// MuhasebeIslemleri<Hizmetli> muhasebeIslemleri1 = new MuhasebeIslemleri<Hizmetli>(); // default constructor olmadığı için hata verir.

