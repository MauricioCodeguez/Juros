using Cotacao.Domain.Queries;
using System.Threading.Tasks;

namespace Cotacao.Domain.Interfaces.Repositories
{
    public interface ICotacaoRepository
    {
        Task<CotacaoQuery> ObterTaxaJuros();
    }
}
