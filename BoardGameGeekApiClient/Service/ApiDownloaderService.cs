using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using BoardGameGeekApiClient.Interfaces;

namespace BoardGameGeekApiClient.Service
{
    public class ApiDownloaderService : IApiDownloadService
    {
        public XDocument DownloadApiResult(Uri requestUrl)
        {
            Debug.WriteLine("Downloading " + requestUrl);
            // Due to malformed header I cannot use GetContentAsync and ReadAsStringAsync :(
            // UTF-8 is now hard-coded...

            XDocument data = null;
            while (data == null )
            {
                var request = WebRequest.CreateHttp(requestUrl);
                request.Timeout = 10000;
                using (var response = (HttpWebResponse)(request.GetResponse()))
                {
                    if (response.StatusCode != HttpStatusCode.OK) continue;

                    using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        data = XDocument.Parse(reader.ReadToEnd());
                    }
                }
            }

            return data;
        }
    }
}