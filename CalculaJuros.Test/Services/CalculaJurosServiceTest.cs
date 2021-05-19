using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Services;
using CalculaJuros.Test.Fakes;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Services
{
    public class CalculaJurosServiceTest
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosServiceTest() => _calculaJurosService = new CalculaJurosService(new FakeCotacaoRepository());

        [Fact]
        public async Task Deve_Retornar_105_Reais_E_10_Centavos_Ao_Iniciar_Valor_Com_100_Reais_No_Periodo_De_5_Meses()
        {
            var valorFinal = await _calculaJurosService.CalcularJuros(100, 5);
            Assert.Equal(105.10, valorFinal.ValorFinal);
        }
    }
}
