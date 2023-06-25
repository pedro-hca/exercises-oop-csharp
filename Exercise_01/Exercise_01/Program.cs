using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + pessoa1.Nome);
            Console.WriteLine("Idade: " + pessoa1.Idade);
            Console.WriteLine("Nome: " + pessoa2.Nome);
            Console.WriteLine("Idade: " + pessoa2.Idade);

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"{pessoa1.Nome} é a pessoa mais velha");
            }
            else
            {
                Console.WriteLine($"{pessoa2.Nome} é a pessoa mais velha");
            }
        }
    }
}