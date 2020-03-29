using System;
using System.Collections.Generic;
using Covirus;

namespace Covirus_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloaderWebClient client = new DownloaderWebClient();
            JsonParser covid = new JsonParser();

            client.DownloadFile("https://pomber.github.io/covid19/timeseries.json", "covid19.json");
            covid.Parser("covid19.json");
            
            
            foreach (KeyValuePair<string, List<Countries>> c in covid.Country) //Percorre o dicionário
            {
                if (c.Key == "Portugal") //Se o país (Key) for igual a "Portugal", então dou print do nome do país e mostro o nº de confirmados por data
                {
                    Console.WriteLine($"Country: {c.Key}");
                
                    foreach (Countries c1 in c.Value)
                    {
                        Console.WriteLine($"{c1.Date}: {c1.Confirmed}");
                    }
                }
            }
        }
    }
}