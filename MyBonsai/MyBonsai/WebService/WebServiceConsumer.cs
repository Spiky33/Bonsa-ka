using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using MyBonsai.Models;
using Newtonsoft.Json;

namespace MyBonsai.WebService
{
    public class WebServiceConsumer
    {
        HttpClient client;

        public WebServiceConsumer()
        {
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
        }

        public BonsaiWikiCatalog GetCatalog()
        {
			var assembly = typeof(WebServiceConsumer).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("MyBonsai.WebService.data.json");

            BonsaiWikiCatalog catalog;

			using (var reader = new System.IO.StreamReader(stream))
			{

				var json = reader.ReadToEnd();
				catalog = JsonConvert.DeserializeObject<BonsaiWikiCatalog>(json);
			}

            return catalog;
        }

        public async Task<BonsaiWikiCatalog> GetCatalogAsync()
        {
            return await GetDataAsync();
        }

        public async Task<BonsaiWikiCatalog> GetDataAsync()
		{
            BonsaiWikiCatalog catalog = null;
			var uri = new Uri("https://drive.google.com/open?id=0B1Wh-4Axr3FUX05IZ1NsZmZfUjA");

			var response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
                catalog = JsonConvert.DeserializeObject<BonsaiWikiCatalog>(content);
			}

            return catalog;
		}
    }
}
