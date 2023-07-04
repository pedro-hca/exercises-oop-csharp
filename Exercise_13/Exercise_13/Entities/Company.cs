using System.Globalization;
namespace Exercise_13.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmplyees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmplyees) : base(name, anualIncome)
        {
            NumberOfEmplyees = numberOfEmplyees;
        }

        public override double Tax()
        {
            double tax = 0.00;
            if (NumberOfEmplyees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
            }
            return tax;
        }
    }
}
