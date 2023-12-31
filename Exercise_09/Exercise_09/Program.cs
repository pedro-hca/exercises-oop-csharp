﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Exercise_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee find = employees.Find(x => x.Id == searchId);

            if (find != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                find.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}