using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace JSON_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("timeseries.json"); //Lê o ficheiro "timeseries.json" na sua totalidade
            
            //Dicionário de Países(Key) e as respetivas mortes/infetados/recuperados (Values)
            Dictionary<string, List<Countries>> country = JsonConvert.DeserializeObject < Dictionary<string, List<Countries>> >(content);

            foreach (KeyValuePair<string, List<Countries>> c in country) //Percorre o dicionário
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