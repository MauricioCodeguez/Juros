using Cotacao.Domain.Queries;
using System.Threading.Tasks;

namespace Cotacao.Domain.Interfaces.Services
{
    public interface ICotacaoService
    {
        Task<CotacaoQuery> ObterTaxaJuros();
    }
}
