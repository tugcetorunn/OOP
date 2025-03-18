using Newtonsoft.Json;
using OOP_40_JSON;

HttpClient client = new HttpClient();

string strJson = client.GetStringAsync("https://reqres.in/api/users?page=2").Result;

Kisi kisi = JsonConvert.DeserializeObject<Kisi>(strJson);

foreach (var item in kisi.data)
{
    Console.WriteLine(item.id + " " + item.email + " " + item.first_name + " " + item.last_name + " " + item.avatar);
}
