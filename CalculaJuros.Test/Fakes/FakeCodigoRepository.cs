using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Test.Fakes
{
    public class FakeCodigoRepository : ICodigoRepository
    {
        public Task<CodigoQuery> ObterUrlCodigoFonte() => Task.FromResult(new CodigoQuery() { Url = "https://github.com/MauricioCodeguez/Juros" });
    }
}
