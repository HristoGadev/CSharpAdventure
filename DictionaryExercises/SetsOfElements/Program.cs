using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var firstSetSize = size[0];
            var secondSetSize = size[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < firstSetSize; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }
            for (int i = 0; i < secondSetSize; i++)
            {
                var number = int.Parse(Console.ReadLine());

                result.Add(number);
            }

            var results = firstSet.Intersect(result);
            
            Console.WriteLine(string.Join(" ", results));

        }
    }
}
