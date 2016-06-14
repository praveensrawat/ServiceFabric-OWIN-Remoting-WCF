using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8471/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/values");
                if (response.IsSuccessStatusCode)
                {
                    string[] output = await response.Content.ReadAsAsync<string[]>();
                    Console.WriteLine("The response from the service call was {0}", output[0]);
                    Console.ReadLine();
                }
            }
        }
    }
}
