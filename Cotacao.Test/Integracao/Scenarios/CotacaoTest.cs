using Cotacao.Domain.Queries;
using Cotacao.Test.Integracao.Fixture;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Cotacao.Test.Integracao.Scenarios
{
    public class CotacaoTest
    {
        private readonly TestContext _testContext;

        public CotacaoTest() => _testContext = new TestContext();

        [Fact]
        public async Task Deve_Retornar_Resposta_Ok_Ao_Fazer_O_Get_Da_Taxa_De_Juros()
        {
            var response = await _testContext.Client.GetAsync("/api/Cotacao/taxaJuros");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Deve_Retornar_1_Por_Cento_Ao_Fazer_O_Get_Da_Taxa_De_Juros()
        {
            var response = await _testContext.Client.GetAsync("/api/Cotacao/taxaJuros");
            response.EnsureSuccessStatusCode();
            var cotacao = JsonSerializer.Deserialize<CotacaoQuery>(await response.Content.ReadAsStringAsync());
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(0.01, cotacao.TaxaJuros);
            Assert.Equal(1, cotacao.TaxaJuros * 100);
        }
    }
}
