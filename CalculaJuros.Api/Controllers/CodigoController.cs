using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodigoController : ControllerBase
    {
        private readonly ICodigoService _codigoService;

        public CodigoController(ICodigoService codigoService) => _codigoService = codigoService;

        [HttpGet]
        [Route("showmethecode")]
        public async Task<CodigoQuery> Get()
            => await _codigoService.ObterUrlCodigoFonte();
    }
}
