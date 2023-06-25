using System;
using System.Globalization;

namespace Exercise_05
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double NotaRestante()
        {
            return 60.0 - Media();
        }

        public void NotaFinal()
        {
            if (Media() > 60)
            {
                Console.WriteLine("NOTA FINAL = " + Media().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + Media().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
