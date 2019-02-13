using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = arr.Sum();
           
            
            long maxNum = sum - arr.Min();
            long minNum = sum - arr.Max();

            Console.Write($"{minNum} {maxNum}");

        }
    }
}
