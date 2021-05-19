using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Infra.Data.Repositories
{
    public class CodigoRepository : ICodigoRepository
    {
        public Task<CodigoQuery> ObterUrlCodigoFonte() => Task.FromResult(new CodigoQuery() { Url = "https://github.com/MauricioCodeguez/Juros" });
    }
}
