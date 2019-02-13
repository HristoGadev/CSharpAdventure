using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            HashSet<string> text = new HashSet<string>();

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    text.Add(input[j]);
                }
            }
            foreach (var item in text.Distinct().OrderBy(x=>x))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
