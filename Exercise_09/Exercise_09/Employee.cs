using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise_09
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * percentage / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
