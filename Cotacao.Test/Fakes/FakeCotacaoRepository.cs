using Cotacao.Domain.Interfaces.Repositories;
using Cotacao.Domain.Queries;
using System.Threading.Tasks;

namespace Cotacao.Test.Fakes
{
    public class FakeCotacaoRepository : ICotacaoRepository
    {
        public Task<CotacaoQuery> ObterTaxaJuros() => Task.FromResult(new CotacaoQuery() { TaxaJuros = 0.01 });
    }
}
