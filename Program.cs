using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new HttpClient();

        var json = "{\"amount_in_rs\":100}";
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync("http://localhost:3000/convert", content);

        var result = await response.Content.ReadAsStringAsync();

        Console.WriteLine(result);
    }
}
