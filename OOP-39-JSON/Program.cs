using Newtonsoft.Json;
using OOP_39_JSON;
using System.Text.Json.Serialization;

Console.WriteLine("ReqRes");

// restful service hangi protokolü kullanıyor? HTTP. http client kullanarak restful servislerle iletişim kurabiliriz.
HttpClient client = new HttpClient();

// client.BaseAddress = new Uri("https://reqres.in/api/users?page=2"); // bu şekilde yazarsak hata alırız. çünkü base address sadece domain kısmını alır.

// client.BaseAddress = new Uri("https://reqres.in/");

string strJSON = client.GetStringAsync("https://reqres.in/api/users?page=2").Result;

Kisi kisi = JsonConvert.DeserializeObject<Kisi>(strJSON);



void VerileriOlustur(string dosyaAdi, string path)
{

    string txt = JsonConvert.SerializeObject(kisi, Formatting.Indented);
    File.WriteAllText(path + "\\" + dosyaAdi, txt);

}

void VerileriOkuma(string dosyaAdi, string path)
{
    Kisi kisi1 = JsonConvert.DeserializeObject<Kisi>(strJSON);

    foreach (var item in kisi1.data)
    {
        Console.WriteLine(item.id + " " + item.email + " " + item.first_name + " " + item.last_name + " " + item.avatar);
    }
}

VerileriOlustur("kisiler.json", "C:\\Users\\halkbank\\Desktop\\Tugce-Torun\\OOP\\OOP-39-JSON");
VerileriOkuma("kisiler.json", "C:\\Users\\halkbank\\Desktop\\Tugce-Torun\\OOP\\OOP-39-JSON");


Console.WriteLine();


