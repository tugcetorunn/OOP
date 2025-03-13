using OOP_21;

Random random = new Random();

Ferrari ferrari = new Ferrari();
ferrari.Renk = (ConsoleColor)random.Next(15);

BMW bmx = new BMW();

Ambulans ambulans = new Ambulans();

Masserati masserati = new Masserati();
masserati.Renk = (ConsoleColor)random.Next(15);

if (ambulans is not IBoyanabilir)
{
    Console.WriteLine("ambulans boyanamaz");
}

Console.WriteLine("Bir renk seçiniz (0-15)");
int renk = int.Parse(Console.ReadLine());
ferrari.Renk = (ConsoleColor)renk;
Console.ForegroundColor = ferrari.Renk;
Console.WriteLine("Ferrari boyandı.");

Console.WriteLine("Bir renk seçiniz (0-15)");
masserati.Renk = (ConsoleColor)int.Parse(Console.ReadLine());
Console.ForegroundColor = masserati.Renk;
Console.WriteLine("Masserati boyandı.");

Console.Clear();

Boyahane boyahane = new Boyahane();
Console.WriteLine("Bir renk seçiniz (0-15)");
boyahane.AracBoya((ConsoleColor)int.Parse(Console.ReadLine()), masserati);

Console.WriteLine();