using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Services;
using CalculaJuros.Test.Fakes;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Services
{
    public class CodigoServiceTest 
    {
        private readonly ICodigoService _codigoService;

        public CodigoServiceTest() => _codigoService = new CodigoService(new FakeCodigoRepository());

        [Fact]
        public async Task Deve_Retornar_Url_Do_Codigo_Fonte_No_Repositorio_Do_Github()
        {
            var codigoFonte = await _codigoService.ObterUrlCodigoFonte();
            Assert.Equal("https://github.com/MauricioCodeguez/Juros", codigoFonte.Url);
        }
    }
}
