// dosya oluşturma

//StreamWriter sw = new StreamWriter("data.txt", true); // C:\Users\halkbank\Desktop\Tugce-Torun\OOP\OOP-35-Files\bin\Debug\net8.0 içinde data.txt oluşturur. append = true girmezsek içeriği silip ekler. true yazarsak üstüne ekler.
//sw.WriteLine("deneme 1 2 3 4");
//sw.Close();

// File.AppendAllLines("data.txt", new string[] { "deneme 5 6 7 8" });

// dosya okuma

StreamReader sr = new StreamReader("data.txt");
// Console.WriteLine(sr.ReadToEnd());

while (!sr.EndOfStream)
{
    Console.WriteLine("> " + sr.ReadLine());
}
sr.Close();
