using System;
using System.Globalization;

namespace Exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentaSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
