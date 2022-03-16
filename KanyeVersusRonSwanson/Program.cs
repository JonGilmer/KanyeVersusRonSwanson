using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace KanyeVersusRonSwanson
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest";
            string ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                var ronSwansonRespone = client.GetStringAsync(ronSwansonURL).Result;
                var ronSwansonQuote = JArray.Parse(ronSwansonRespone).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


                Console.WriteLine($"Kanye: \"{kanyeQuote}.\"");
                Console.WriteLine($"Ron: {ronSwansonQuote}");
                Console.WriteLine();
                Thread
            }
        }
    }
}
