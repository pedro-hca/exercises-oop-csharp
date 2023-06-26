using System;
using System.Globalization;

namespace Exercise_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ConverteDolar(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}