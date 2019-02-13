using System;
using System.Linq;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] chocolate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ronInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int sumNumber = ronInfo[0];
            int lenght = ronInfo[1];
            int counter = 0;

            if (chocolate.Length == 1 && chocolate[0] == sumNumber)
            {
                counter++;
            }
            int sum = 0;
            for (int i = 0; i < chocolate.Length; i++)
            {
                for (int j = i; j < j+lenght; j++)
                {
                     sum += chocolate[j];
                   
                }
                if (sumNumber == sum)
                {
                    counter++;
                }
                else
                {
                    sum = 0;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
