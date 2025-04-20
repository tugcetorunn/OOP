LinkedList<string> history = new LinkedList<string>();

// Başlangıçta bazı sayfalar ziyaret ediliyor
history.AddLast("google.com");
history.AddLast("youtube.com");
history.AddLast("wikipedia.org");

// Şu an hangi sayfadayız?
LinkedListNode<string> current = history.Last;
Console.WriteLine($"Başlangıç: {current.Value}");

// Geri tuşuna basılıyor
if (current.Previous != null)
{
    current = current.Previous;
    Console.WriteLine($"Geri gidildi: {current.Value}");
}

// Tekrar geri
if (current.Previous != null)
{
    current = current.Previous;
    Console.WriteLine($"Geri gidildi: {current.Value}");
}

// Yeni sayfa ziyaret edildi: önceki ileri bağlantılar kopar
var nextNode = current.Next;
while (nextNode != null)
{
    var temp = nextNode;
    nextNode = nextNode.Next;
    history.Remove(temp); // ileri geçmişi temizle
}

// Yeni sayfa ekleniyor
history.AddAfter(current, "stackoverflow.com");
current = current.Next;
Console.WriteLine($"Yeni sayfa: {current.Value}");

// Tüm geçmişi yazdır
Console.WriteLine("\nTarayıcı geçmişi:");
foreach (var page in history)
{
    Console.WriteLine($"- {page}");
}
