using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string sanityApiUrl = "https://mdr7r2qw.api.sanity.io/v2022-03-07/data/query/production?query=*%5B_type+%3D%3D+%27Goods%27%5D+";
        string apiKey = "yourApiKey";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            HttpResponseMessage response = await client.GetAsync(sanityApiUrl);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                // Deserialize the JSON content into your C# objects
                // Display or use the content as needed
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
