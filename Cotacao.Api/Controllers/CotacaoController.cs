using Cotacao.Domain.Interfaces.Services;
using Cotacao.Domain.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cotacao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoController(ICotacaoService cotacaoService) => _cotacaoService = cotacaoService;

        [HttpGet]
        [Route("taxaJuros")]
        public async Task<CotacaoQuery> Get() => await _cotacaoService.ObterTaxaJuros();
    }
}
