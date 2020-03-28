using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Covirus
{
    public class DownloaderHttpClient
    {
        private JsonParser parser = new JsonParser();
        
        public async Task DownloadFile(string link)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(link);
            response.EnsureSuccessStatusCode();

            var res = await client.GetStringAsync(link);
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(res);
            parser.Parser(res);
        }
    }
}