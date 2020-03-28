using System;
using System.Collections.Generic;
using Covirus;

namespace Covirus_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Downloader downloader = new Downloader();
            JsonParser jp = new JsonParser();

            downloader.DownloadFile("https://pomber.github.io/covid19/timeseries.json", "timeseries.json");
            jp.Parser("timeseries.json");
        }
    }
}