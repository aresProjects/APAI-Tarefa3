using System;
using System.Net;

namespace Covirus
{
    public class Downloader
    {
        public void DownloadFile(string address, string file)
        {
            WebClient site = new WebClient();
            
            site.DownloadFile(address, file);
        }
    }
}