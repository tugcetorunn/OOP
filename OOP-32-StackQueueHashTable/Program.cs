using System.Collections;

Stack<int> stack = new Stack<int>();

stack.Push(71);
stack.Push(22);
stack.Push(38);

Console.WriteLine(stack.Peek()); // en üstteki elemanı döndürür.
Console.WriteLine(stack.Count);

Console.WriteLine(stack.Pop()); // en üstteki elemanı siler ve döndürür.
Console.WriteLine(stack.Count);

Queue<string> queue = new Queue<string>();
queue.Enqueue("Ankara");
queue.Enqueue("İstanbul");
queue.Enqueue("Bursa");

Console.WriteLine(queue.Dequeue()); // en üstteki elemanı siler ve döndürür.
Console.WriteLine(queue.Count);
Console.WriteLine(queue.Peek()); // en üstteki elemanı döndürür. silmez.
Console.WriteLine(queue.Count);

Dictionary<int, string> sehirler = new Dictionary<int, string>();
sehirler.Add(6, "Ankara");
sehirler.Add(34, "İstanbul");
sehirler.Add(16, "Bursa");

Console.WriteLine(sehirler[16]); // sehirler[16] c# ta bu yapı indexer olarak geçer. key değeri vererek value değerini döndürür.

Console.WriteLine();