// dosya oluşturma

StreamWriter sw = new StreamWriter("data.txt", true); // C:\Users\halkbank\Desktop\Tugce-Torun\OOP\OOP-35-Files\bin\Debug\net8.0içinde data.txt oluşturur. append = true girmezsek içeriği silip ekler. true yazarsak üstüne ekler.
sw.WriteLine("deneme 1 2 3 4");
sw.Close();

File.AppendAllLines("data.txt", new string[] { "deneme 5 6 7 8" }); // dosyaya yeni satır ekler. append = true girmezsek içeriği silip ekler. true yazarsak üstüne ekler.

// File.Delete("data.txt"); // dosyayı siler. dosya açıkken silinemez. dosya kapalı olmalı.
File.Copy("data.txt", "data2.txt", true); // dosyayı kopyalar. dosya açıkken kopyalanamaz. dosya kapalı olmalı. true yazarsak üstüne ekler.
// File.Move("data.txt", "data2.txt"); // dosyayı taşır. dosya açıkken taşınamaz. dosya kapalı olmalı.

// dosya okuma

StreamReader sr = new StreamReader("data.txt");
// Console.WriteLine(sr.ReadToEnd());

while (!sr.EndOfStream)
{
    Console.WriteLine("> " + sr.ReadLine());
}
sr.Close();
