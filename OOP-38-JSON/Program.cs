using Newtonsoft.Json;
using OOP_38_JSON;

Console.WriteLine("JSON");

StreamReader sr = new StreamReader("../../../kitap.json"); // tek kitap.json yazsaydık OOP-38-JSON\bin\Debug\net8.0 içinde arardı. üç dosya geri gidiyoruz OOP-38-JSON a gitmek için.
string strJson = sr.ReadToEnd();

var kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(strJson);

foreach (var kitap in kitaplar)
{
    Console.WriteLine($"{kitap.Id} {kitap.Ad} {kitap.Yazar} {kitap.Fiyat}");
}

Console.WriteLine("Json string " + JsonConvert.SerializeObject(kitaplar));

Console.WriteLine();