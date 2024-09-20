using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("http://localhost:51369/").Result;
                var content = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(content);
            }
        }
    }
}
