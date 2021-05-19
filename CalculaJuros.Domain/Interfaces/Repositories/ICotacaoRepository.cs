using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Interfaces.Repositories
{
    public interface ICotacaoRepository
    {
        Task<CotacaoQuery> ObterCotacao();
    }
}
