using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Queries;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalculaJuros.Infra.Data.Repositories
{
    public class CotacaoRepository : ICotacaoRepository
    {
        private readonly IConfiguration _config;

        public CotacaoRepository(IConfiguration config) => _config = config;

        private HttpClient CreateHttpClient()
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            };

            var httpClient = new HttpClient(handler);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            httpClient.Timeout = TimeSpan.FromMinutes(10);
            return httpClient;
        }

        public async Task<CotacaoQuery> ObterCotacao()
        {
            var cliente = CreateHttpClient();
            var response = await cliente.GetAsync($"{_config["ApiCotacaoUrl"]}api/Cotacao/taxaJuros");
            var result = JsonSerializer.Deserialize<CotacaoQuery>(await response.Content.ReadAsStringAsync());
            return result;
        }
    }
}
