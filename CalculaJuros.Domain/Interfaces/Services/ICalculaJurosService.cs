using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Interfaces.Services
{
    public interface ICalculaJurosService
    {
        Task<CalculaJurosQuery> CalcularJuros(double valorInicial, int meses);
    }
}
