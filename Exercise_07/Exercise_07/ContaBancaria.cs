using System;
using System.Globalization;

namespace Exercise_07
{
    internal class ContaBancaria
    {
        private string Titular { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numero, double valor) : this(nome, numero)
        {
            Saldo = valor;
        }

        public ContaBancaria(string nome, int numero)
        {
            Titular = nome;
            NumeroConta = numero;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }


        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
