using CalculaJuros.Domain.Extensions;
using CalculaJuros.Domain.Interfaces.Repositories;
using CalculaJuros.Domain.Interfaces.Services;
using CalculaJuros.Domain.Queries;
using System;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CalculaJurosService(ICotacaoRepository cotacaoRepository) => _cotacaoRepository = cotacaoRepository;

        public async Task<CalculaJurosQuery> CalcularJuros(double valorInicial, int meses)
        {
            var cotacao = await _cotacaoRepository.ObterCotacao();
            var valorFinal = valorInicial * Math.Pow(1 + cotacao.TaxaJuros, meses);
            return new CalculaJurosQuery() { ValorFinal = valorFinal.Truncate(2) };
        }
    }
}
