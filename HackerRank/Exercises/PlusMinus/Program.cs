using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double counterNegative = 0;
            double counterPositive = 0;
            double counterNull = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    counterNegative++;
                }
                else if (numbers[i]>0)
                {
                    counterPositive++;
                }
                else if (numbers[i]==0)
                {
                    counterNull++;
                }
            }
            double negativeRatios = counterNegative / n;
            double positiveRatios = counterPositive / n;
            double nullRatios = counterNull / n;

            Console.WriteLine($"{positiveRatios:f6}");
            Console.WriteLine($"{negativeRatios:f6}");
            Console.WriteLine($"{nullRatios:f6}");
        }
    }
}
