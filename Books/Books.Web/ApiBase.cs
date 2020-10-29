using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Books.Web
{
    public class ApiBase
    {
        private readonly string _uri;

        private ApiBase(string uri)
        {
            _uri = uri;
        }

        public static ApiBase ApiVolume = new ApiBase("https://localhost:5001/api/books/");

        public async Task<TResult> Get<TResult>(string uriParams)
        {
            TResult result = default;
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using var response = await client.GetAsync(MonteUri(uriParams));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<TResult>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public async Task Post<TParam>(TParam conteudo, string uriParams)
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var serialized = new StringContent(JsonConvert.SerializeObject(conteudo), Encoding.UTF8, "application/json");
                using var response = await client.PostAsync(MonteUri(uriParams), serialized);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task Delete(string uriParams)
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using var response = await client.DeleteAsync(MonteUri(uriParams));
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string MonteUri(string uriParams)
        {
            return $"{_uri}{uriParams}";
        }
    }
}
