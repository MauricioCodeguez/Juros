using Cotacao.Domain.Interfaces.Services;
using Cotacao.Domain.Services;
using Xunit;

namespace Cotacao.Test.Services
{
    public class CotacaoServiceTest
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoServiceTest() => _cotacaoService = new CotacaoService(new Fakes.FakeCotacaoRepository());

        [Fact]
        public async void Deve_Retornar_1_Por_Cento()
        {
            var taxaDeJuros = await _cotacaoService.ObterTaxaJuros();
            Assert.Equal(0.01, taxaDeJuros.TaxaJuros);
            Assert.Equal(1, taxaDeJuros.TaxaJuros * 100);
        }
    }
}
