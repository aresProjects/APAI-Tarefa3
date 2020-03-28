using System;
using System.Collections.Generic;
using Covirus;

namespace Covirus_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloaderWebClient downloaderWebClient = new DownloaderWebClient();
            JsonParser jParser = new JsonParser();

            downloaderWebClient.DownloadFile("https://pomber.github.io/covid19/timeseries.json", "timeseries.json");
            jParser.Parser("timeseries.json");
        }
    }
}