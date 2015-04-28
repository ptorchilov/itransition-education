namespace ConsoleClient
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Xml.Linq;

    public class Program
    {
        private const String CurrentApiUrl = "http://localhost:50013/";

        public static void Main()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/xml"));

            var result = client.GetAsync(new Uri(CurrentApiUrl.TrimEnd('/') + "/api/videos")).Result;

            if (result.StatusCode == HttpStatusCode.OK)
            {
                var doc = XDocument.Load(result.Content.ReadAsStreamAsync().Result);
                var ns = (XNamespace)"http://schemas.datacontract.org/2004/07/WebApiProject.Models";

                foreach (var title in doc.Descendants(ns + "Title"))
                {
                    Console.WriteLine(title.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
