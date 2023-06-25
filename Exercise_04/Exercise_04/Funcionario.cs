using System;
using System.Globalization;

namespace Exercise_04
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
