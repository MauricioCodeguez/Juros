using Cotacao.Api.Interfaces.Services;
using Cotacao.Api.Services;
using Xunit;

namespace Cotacao.Test.Services
{
    public class CotacaoServiceTest
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoServiceTest() => _cotacaoService = new CotacaoService();

        [Fact]
        public async void Deve_Retornar_1_Por_Cento()
        {
            var taxaDeJuros = await _cotacaoService.ObterTaxaDeJuros();
            Assert.Equal(0.01, taxaDeJuros);
        }
    }
}
