List<int> list = new List<int>(100); // list<> in 3 constructor u var. 1. default constructor, 2. int capacity, 3. IEnumerable<T> collection

for (int i = 0; i < 101; i++)
    list.Add(i);

Console.WriteLine($"adet : {list.Count}");
Console.WriteLine($"kapasite : {list.Capacity}");

// veriler belliyse kapasiteyi yazabiliriz. bu sayede performans artar. 
// yazdığımız kapasitenin üstüne çıkarsa veriler, list<> otomatik olarak kapasiteyi 2 katına çıkarır.
// c# 2.0 öncesi collectionlardan uzak durmak lazım. çünkü performans sorunları var. 2.0 dan sonra generic collectionlar geldi.
