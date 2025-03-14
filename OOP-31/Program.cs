// enum - numeric değerlerle string değerleri eşleştirmekte kullanılır.
// ardışık sıralama ister. sayı önceki sayıdan 1 büyük olmalıdır.

using OOP_31;

for (int i = 0; i < 16; i++)
{
    Console.ForegroundColor = (ConsoleColor)i;
    Console.WriteLine(Enum.GetName((ConsoleColor)i));
}

Gunler gun = Gunler.Cuma;
Console.WriteLine(gun);
Console.WriteLine((int)gun);

Personel personel = new Personel();
personel.IzinGunu = Gunler.Cuma;



Console.WriteLine();