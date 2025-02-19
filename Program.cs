using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        List<Task<HttpResponseMessage>> tasks = new(); 
        int i = 1;
        client.Timeout = TimeSpan.FromMinutes(353);
        while (i<100000)
        {

            i++;

            tasks.Add(client.GetAsync("https://goninjio.com/landingPage/interactiveTeachable/2/3b627b38ae8d11eeb8580242ac190102"));

            Console.WriteLine("***********************************");
            Console.WriteLine(i.ToString());
            Console.WriteLine("***********************************");

        }
        HttpResponseMessage[] responses = await Task.WhenAll(tasks);


    }
}
