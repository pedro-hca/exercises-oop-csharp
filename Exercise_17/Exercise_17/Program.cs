using System;

namespace Exercise_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();
            HashSet<int> setC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                setA.Add(id);
            }

            Console.Write("How many students for course B? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int id = int.Parse(Console.ReadLine());
                setB.Add(id);
            }

            Console.Write("How many students for course C? ");
            int y = int.Parse(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                int id = int.Parse(Console.ReadLine());
                setC.Add(id);
            }

            HashSet<int> union = new HashSet<int>(setA);
            union.UnionWith(setB);
            union.UnionWith(setC);
            Console.WriteLine("Total students: " + union.Count);
        }
    }
}