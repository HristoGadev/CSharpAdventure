using System;
using System.Linq;

namespace LegoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var jaggedArr1 = new string[n][];
            var jaggedArr2 = new string[n][];

            var countArr1 = 0;
            var countArr2 = 0;

            for (int row = 0; row < n; row++)
            {
                jaggedArr1[row] = Console.ReadLine()
                    .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                countArr1 += jaggedArr1[row].Length;
            }
            for (int row = 0; row < n; row++)
            {
                jaggedArr2[row] = Console.ReadLine()
                    .Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                    .Reverse()
                    .ToArray();
                countArr2 += jaggedArr2[row].Length;
            }
            
            var totalCount = countArr1 + countArr2;

            var sumArrLenght = jaggedArr1[0].Length + jaggedArr2[0].Length;
            var isEqual = true;

            for (int i = 1; i < n; i++)
            {
                var currentSumLenght = jaggedArr1[i].Length + jaggedArr2[i].Length;
                if (sumArrLenght == currentSumLenght)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            
            if (isEqual!=true)
            {
                Console.WriteLine($"The total number of cells is: {totalCount}");
            }
            else
            {
                for (int row = 0; row < n; row++)
                {
                    var jaggedArrResult =jaggedArr1[row].Concat(jaggedArr2[row]).ToArray();
                   
                    Console.WriteLine($"[{string.Join(", ",jaggedArrResult)}]");
                   
                }
                
            }
        }
    }
}
