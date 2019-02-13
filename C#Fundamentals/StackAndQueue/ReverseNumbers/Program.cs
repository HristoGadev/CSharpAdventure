using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            Stack<long> reversed = new Stack<long>();

            for (long i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }

            while (reversed.Count != 0)
            {
                Console.Write(reversed.Pop() + " ");
            }
            Console.WriteLine();


        }
    }
}
