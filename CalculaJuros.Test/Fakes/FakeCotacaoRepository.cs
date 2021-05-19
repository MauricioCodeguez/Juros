using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Test.Fakes
{
    public class FakeCotacaoRepository : ICotacaoRepository
    {
        public Task<CotacaoQuery> ObterCotacao() => Task.FromResult(new CotacaoQuery() { TaxaJuros = 0.01 });
    }
}
