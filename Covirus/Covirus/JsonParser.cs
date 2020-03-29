using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Covirus
{
    public class JsonParser
    {
        private Dictionary<string, List<Countries>> country;

        public Dictionary<string, List<Countries>> Country { get => country; }

        public void Parser(string file)
        {
            string content = File.ReadAllText(file); //Lê o ficheiro "timeseries.json" na sua totalidade
            
            //Dicionário de Países(Key) e as respetivas mortes/infetados/recuperados (Values)
            country = JsonConvert.DeserializeObject < Dictionary<string, List<Countries>> >(content);
        }
    }
}