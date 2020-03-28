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
            JsonParser jParser = new JsonParser();

            client.DownloadFile("https://pomber.github.io/covid19/timeseries.json", "covid19.json");
            jParser.Parser("covid19.json");
        }
    }
}