using CalculaJuros.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace CalculaJuros.Test.Integracao.Fixture
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public TestContext() => SetupClient();

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>()
                .ConfigureAppConfiguration((ctx, config) => 
                {
                    config.AddJsonFile("appsettings.json");
                }));
            Client = _server.CreateClient();
        }
    }
}
