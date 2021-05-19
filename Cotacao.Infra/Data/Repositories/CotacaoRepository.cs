using Cotacao.Domain.Interfaces.Repositories;
using Cotacao.Domain.Queries;
using System.Threading.Tasks;

namespace Cotacao.Infra.Data.Repositories
{
    public class CotacaoRepository : ICotacaoRepository
    {
        public async Task<CotacaoQuery> ObterTaxaJuros() => await Task.FromResult(new CotacaoQuery() { TaxaJuros = 0.01 });
    }
}
