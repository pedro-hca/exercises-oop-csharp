using System;
using System.Globalization;

namespace Exercise_06
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ConverteDolar(double cotacao, double quantidade)
        {
            return (cotacao * quantidade) + ((cotacao * quantidade) * Iof);
        }



    }
}
