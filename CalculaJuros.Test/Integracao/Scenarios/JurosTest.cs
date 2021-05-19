using CalculaJuros.Test.Integracao.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Integracao.Scenarios
{
    public class JurosTest
    {
        private readonly TestContext _testContext;

        public JurosTest() => _testContext = new TestContext();

        [Fact]
        public async Task Deve_Retornar_Resposta_Ok_Ao_Fazer_O_Get_Do_Calculo_De_Juros()
        {
            var response = await _testContext.Client.GetAsync("/api/Juros/calculaJuros?valorInicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
