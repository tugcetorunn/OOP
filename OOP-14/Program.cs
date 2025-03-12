List<int> sayilar = new List<int>();

for (int i = 0; i < 815698; i++)
    sayilar.Add(i);

Console.WriteLine($"adet : {sayilar.Count}"); // 1, 5, 10
Console.WriteLine($"kapasite : {sayilar.Capacity}"); // 4, 8, 16 kendi belirliyor. pattern var, fakat freakans aralığı da değişken adet arttıkça aralık azalıyor. bunun sebebi; resize maliyetini (kopyalama maliyeti) ve ram maliyetini düşürmek.

// bu yüzden boyutunu bildiğim verilerde array kullanmak daha performanslıdır. 

// strongly type programlama dili -> c#
Console.WriteLine();

