// 1-10 arası not verilen bir sistemde 100 öğrenci için rastgele notları oluşturup, notları bir dosyaya yazın sonra, bu dosyayı okuyarak her notun frekansını bulunuz. (öğr adı tutmaya gerek yok, sadece not tutulacak.)


Random random = new Random();
List<int> notlar = new List<int>();
for (int i = 0; i < 100; i++)
{
    notlar.Add(random.Next(1, 11));
}

StreamWriter sw = new StreamWriter("notlar.txt");

foreach (var not in notlar)
{
    sw.WriteLine(not);
}
sw.Close();

List<int> dosyadakiNotlar = new List<int>();
int[] frekanslar = new int[10];

StreamReader sr = new StreamReader("notlar.txt");

while (!sr.EndOfStream)
{
    dosyadakiNotlar.Add(int.Parse(sr.ReadLine()));
}
sr.Close();

for (int i = 1; i < 11; i++)
{
    foreach(var not in dosyadakiNotlar)
    {
        if (i == not)
        {
            frekanslar[i-1]++;
            
        }
    }
    Console.WriteLine(i + " için : " + frekanslar[i - 1]);
}

Console.WriteLine();