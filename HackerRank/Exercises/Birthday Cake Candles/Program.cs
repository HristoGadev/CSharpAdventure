using System;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxNumber =arr.Max();
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==maxNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
