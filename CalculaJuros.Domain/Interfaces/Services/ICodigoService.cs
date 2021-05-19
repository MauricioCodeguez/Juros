using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Interfaces.Services
{
    public interface ICodigoService
    {
        Task<CodigoQuery> ObterUrlCodigoFonte();
    }
}
