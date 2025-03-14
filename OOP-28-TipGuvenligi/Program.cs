using System.Collections;

ArrayList liste = new ArrayList();
liste.Add(5);
liste.Add(17);
liste.Add(7);
liste.Add("sa");

int toplam = 0;
foreach (int item in liste)
    toplam += item;

Console.WriteLine(toplam);

List<int> liste2 = new List<int>();
liste2.Add(5);
liste2.Add(17);
//liste2.Add("on");

// performans (boxing-unboxing i önlüyo)
// tip güvenliği

// compile time safety (copilot yazdı)
// bu sebeplerden dolayı generic yapıları kullanmalıyız.

