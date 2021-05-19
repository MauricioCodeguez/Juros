using System;

namespace CalculaJuros.Domain.Extensions
{
    public static class TruncateExtension
    {
        public static double Truncate(this double num, int precision)
        {
            double y = Math.Pow(10, precision);
            return Math.Truncate(num * y) / y;
        }
    }
}
