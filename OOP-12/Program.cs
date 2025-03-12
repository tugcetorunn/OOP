// bir arraylist oluşturup içerisine musteri, personel sınıfları atınız.
// personelde id, ad, soyad, maas
// musteri de id, ad, soyad, caridurum bilgileri olsun.
// tüm listeyi ekrana yazdırınız.

using OOP_12;
using System.Collections;

Random random = new Random();

ArrayList list = new ArrayList();

// Personel personel = new Personel { Id = 1, Name = "Melek", Surname = "Arı", Salary = 19000 };
//Personel personel2 = new Personel { Id = 2, Name = "Ayşe", Surname = "Arı", Salary = 36000 };
//Personel personel3 = new Personel { Id = 3, Name = "Fatma", Surname = "Ateş", Salary = 45000 };

// Customer customer = new Customer { Id = 1, Name = "Bahar", Surname = "Güneş", CariDurum = CariDurum.Alacaklı };
//Customer customer2 = new Customer { Id = 2, Name = "Yağmur", Surname = "Başar", CariDurum = CariDurum.Borclu };
//Customer customer3 = new Customer { Id = 3, Name = "Fatih", Surname = "Aslan", CariDurum = CariDurum.Alacaklı };

//personelList.Add(personel);
//personelList.Add(personel2);
//personelList.Add(personel3);

//customerList.Add(customer);
//customerList.Add(customer2);
//customerList.Add(customer3);

List<string> names = new List<string> { "Melek", "Ayşe", "Fatma", "Bahar", "Yağmur", "Fatih" };
List<string> surnames = new List<string> { "Arı", "Güneş", "Ateş", "Başar", "Aslan"};

for (int i = 0; i <= 5; i++)
{
    Person personel = new Personel { Id = i + 1, Name = names[random.Next(names.Count)], Surname = surnames[random.Next(surnames.Count)], Salary = random.Next(10000, 50000) };
    list.Add(personel);
}

for (int i = 0; i <= 5; i++)
{
    Person customer = new Customer { Id = i + 1, Name = names[random.Next(names.Count)], Surname = surnames[random.Next(surnames.Count)], CariDurum = (CariDurum)random.Next(0,1) };
    list.Add(customer);
}

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}


foreach(Personel item in list)
    if(item is Person)
    Console.WriteLine(item.GetInformation());