using Books.Dominio.DTOs;
using Books.Dominio.Extensoes;
using Books.Dominio.Interfaces;
using Books.Dominio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Books.Dominio.Services
{
    public class BooksService : IBooksService
    {
        private const string URI = "https://www.googleapis.com/books/v1/";
        public async Task<VolumeResult> ObtenhaLivrosPorTermo(string filtro)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var query = $"volumes?q={filtro}";

            var response = await client.GetAsync(query);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(content))
                {
                    return new VolumeResult();
                }
                var result = JsonConvert.DeserializeObject<DTOBooksResult>(content);
                var volumes = result.Items;
                return new VolumeResult
                {
                    Items = volumes.ToList().Converta()
                };            
            }
            return new VolumeResult();
        }
    }
}
