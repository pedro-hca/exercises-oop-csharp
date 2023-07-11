using System;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> votos = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] split = sr.ReadLine().Split(',');
                        string name = split[0];
                        int id = int.Parse(split[1]);

                        if (votos.ContainsKey(name))
                        {
                            votos[name] += id;
                        }
                        else
                        {
                            votos[name] = id;
                        }
                    }
                    foreach (var item in votos)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}