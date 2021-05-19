using System;

namespace CalculaJuros.Domain.Extensions
{
    public static class TruncateExtension
    {
        public static decimal Truncate(this decimal num, int precision)
        {
            decimal y = (decimal)Math.Pow(10, precision);
            return Math.Truncate(num * y) / y;
        }
    }
}
