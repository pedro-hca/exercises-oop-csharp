using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1, func2;

            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("DIGITE O NOME DO PRIMEIRO FUNCIONÁRIO:");
            func1.Nome = Console.ReadLine();
            Console.WriteLine("DIGITE O SALARIO DO PRIMEIRO FUNCIONÁRIO:");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIGITE O NOME DO SEGUNDO FUNCIONÁRIO:");
            func2.Nome = Console.ReadLine();
            Console.WriteLine("DIGITE O SALARIO DO SEGUNDO FUNCIONÁRIO:");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + func1.Nome);
            Console.WriteLine("Salário: " + func1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: " + func2.Nome);
            Console.WriteLine("Salário: " + func2.Salario.ToString("F2", CultureInfo.InvariantCulture));

            double salariomedio = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salariomedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}