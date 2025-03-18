using OOP_45_Delegates;

List<Urun> urunler = new List<Urun>() 
{ 
    new Urun { Id = 1, Ad = "defter", Fiyat = 45, Kategori = "Kırtasiye"}, 
    new Urun { Id = 2, Ad = "kalem", Fiyat = 75, Kategori = "Kırtasiye"}, 
    new Urun { Id = 3, Ad = "silgi", Fiyat = 27, Kategori = "Kırtasiye"}, 
    new Urun { Id = 4, Ad = "top", Fiyat = 1255, Kategori = "Hobi"}, 
    new Urun { Id = 5, Ad = "raket", Fiyat = 540, Kategori = "Hobi"}, 
    new Urun { Id = 6, Ad = "puzzle", Fiyat = 245, Kategori = "Puzzle"}
};

// id si 5 olan ürünü bulan metodu yazın
// kategorisi hobi olan ürünleri bulan metodu yazın
// ürün adında u geçen ürünleri bulan metodu yazın

void FindById(int id, List<Urun> products)
{
    Console.WriteLine(products.FirstOrDefault(x => x.Id == id));
}

void FindByCategory(string categoryName, List<Urun> products)
{
    foreach (var item in products.FindAll(x => x.Kategori == categoryName))
    {
        Console.WriteLine(item.Id + " " + item.Ad + " " + item.Fiyat + " " + item.Kategori);
    }
}

void GetProducts(char character, List<Urun> products)
{
    foreach (var item in products.Where(x => x.Ad.Contains(character)).ToList())
    {
        Console.WriteLine(item.ToString());
    }
}

// 2. yöntem

// delegate ile tek metodla yapabiliriz.

IEnumerable<Urun> Filtrele(Func<Urun, bool> where)
{
    return urunler.Where(where);
}

void Yazdir(IEnumerable<Urun> urunler)
{
    foreach (var urun in urunler)
    {
        Console.WriteLine(urun.ToString());
    }
}

Yazdir(Filtrele(x => x.Id == 5));
Console.WriteLine("-------------");
Yazdir(Filtrele(x => x.Kategori == "Hobi"));
Console.WriteLine("-------------");
Yazdir(Filtrele(x => x.Ad.Contains('u')));

Console.WriteLine();



