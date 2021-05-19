using Cotacao.Domain.Interfaces.Repositories;
using Cotacao.Domain.Interfaces.Services;
using Cotacao.Domain.Queries;
using System.Threading.Tasks;

namespace Cotacao.Domain.Services
{
    public class CotacaoService : ICotacaoService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoService(ICotacaoRepository cotacaoRepository) => _cotacaoRepository = cotacaoRepository;

        public async Task<CotacaoQuery> ObterTaxaJuros() => await _cotacaoRepository.ObterTaxaJuros();
    }
}
