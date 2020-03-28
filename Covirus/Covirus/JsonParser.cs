using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Covirus
{
    public class JsonParser
    {
        public void Parser(string file)
        {
            string content = File.ReadAllText(file); //Lê o ficheiro "timeseries.json" na sua totalidade
            
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