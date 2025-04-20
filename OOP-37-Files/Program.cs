void VerileriOlustur(string dosyaAdi, int notAdedi)
{
    StreamWriter sw = new StreamWriter(dosyaAdi);

    for (int i = 0; i < notAdedi; i++)
    {
        sw.WriteLine(new Random().Next(1, 11));
    }

    sw.Close();
}

Dictionary<int, int> SonuclariGoster(string dosyaAdi)
{
    Dictionary<int, int> frekanslar = new Dictionary<int, int>();
    for (int i = 1; i < 11; i++)
    {
        frekanslar.Add(i, 0);
    }
    StreamReader sr = new StreamReader(dosyaAdi);
    while (!sr.EndOfStream)
    {
        int not = int.Parse(sr.ReadLine());

        // frekanslar.Add(not, frekanslar[not]++); // frekanslar[not] olmadığı için hata verir. ilk değer ataması yapılması lazım.
        //frekanslar[not]++;

        if (frekanslar.ContainsKey(not))
        {
            frekanslar[not]++;
        }
        else
        {
            frekanslar.Add(not, 1);
        }

    }

    sr.Close();

    return frekanslar;
}

VerileriOlustur("notes.dat", 100); // .xyz de yazsak text dosyası olarak kaydolur. fakat içine string kaydetmek için txt editör ile açmak gerekir önce.
foreach (var frekans in SonuclariGoster("notes.dat"))
{
    Console.WriteLine(frekans.Key + " " + frekans.Value);
}

Console.WriteLine();