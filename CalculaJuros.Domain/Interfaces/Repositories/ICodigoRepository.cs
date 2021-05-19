using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Interfaces.Repositories
{
    public interface ICodigoRepository
    {
        Task<CodigoQuery> ObterUrlCodigoFonte();
    }
}
