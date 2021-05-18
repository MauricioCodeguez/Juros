using System.Threading.Tasks;

namespace Cotacao.Api.Interfaces.Services
{
    public interface ICotacaoService
    {
        Task<double> ObterTaxaDeJuros();
    }
}
