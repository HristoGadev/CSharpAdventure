using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            
            for (int i = 0; i < size; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(number) == false)
                {
                    numbers.Add(number, 0);
                }
                numbers[number] += 1;

            }
            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }

            }

        }
    }
}
