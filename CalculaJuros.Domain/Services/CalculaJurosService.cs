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
            return new CalculaJurosQuery() { ValorFinal = Truncate(valorFinal, 2) };
        }

        public static double Truncate(double num, int precision)
        {
            double y = Math.Pow(10, precision);
            return Math.Truncate(num * y) / y;
        }

        public static decimal Truncate(decimal num, int precision)
        {
            decimal y = (decimal)Math.Pow(10, precision);
            return Math.Truncate(num * y) / y;
        }
    }
}
