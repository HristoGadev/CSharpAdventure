using System;
using System.Linq;

namespace SumPrimeDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int[number, number];


            int sumFirstDiagonal = 0;
            int firstDiagonalNumber = 0;
            for (int row = 0; row <= number - 1; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col <= number - 1; col++)
                {
                    matrix[row, col] = input[col];
                    if (row == col)
                    {
                        firstDiagonalNumber = matrix[row, col];
                        sumFirstDiagonal += firstDiagonalNumber;
                    }
                }

            }
            Console.WriteLine(sumFirstDiagonal);
        }
    }
}
