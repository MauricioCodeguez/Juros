using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Queries;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Services
{
    public class CodigoService : ICodigoService
    {
        private readonly ICodigoRepository _codigoRepository;

        public CodigoService(ICodigoRepository codigoRepository) => _codigoRepository = codigoRepository;

        public async Task<CodigoQuery> ObterUrlCodigoFonte() => await _codigoRepository.ObterUrlCodigoFonte();
    }
}
