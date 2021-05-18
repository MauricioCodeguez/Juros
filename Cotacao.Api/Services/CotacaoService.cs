using Cotacao.Api.Interfaces.Services;
using System.Threading.Tasks;

namespace Cotacao.Api.Services
{
    public class CotacaoService : ICotacaoService
    {
        public async Task<double> ObterTaxaDeJuros()
        {
            return await Task.FromResult(0.01);
        }
    }
}
