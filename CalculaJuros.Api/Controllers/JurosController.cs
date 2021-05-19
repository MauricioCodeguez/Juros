using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public JurosController(ICalculaJurosService calculaJurosService) => _calculaJurosService = calculaJurosService;

        [HttpGet]
        [Route("calculaJuros")]
        public async Task<CalculaJurosQuery> Get([FromQuery] double valorInicial, [FromQuery] int meses)
            => await _calculaJurosService.CalcularJuros(valorInicial, meses);
    }
}
