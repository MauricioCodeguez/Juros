using CalculaJuros.Test.Integracao.Fixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Integracao.Scenarios
{
    public class CodigoTest
    {
        private readonly TestContext _testContext;

        public CodigoTest() => _testContext = new TestContext();

        [Fact]
        public async Task Deve_Retornar_Resposta_Ok_Ao_Fazer_O_Get_Para_Obter_Url_Do_Codigo_Fonte()
        {
            var response = await _testContext.Client.GetAsync("/api/Codigo/showmethecode");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
