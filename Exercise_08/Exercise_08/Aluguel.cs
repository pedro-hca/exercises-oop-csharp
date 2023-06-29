using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Exercise_08
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}