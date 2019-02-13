using System;
using System.Linq;

namespace Problem4.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtMatrix = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            var matrix = new int[lenghtMatrix[0], lenghtMatrix[1]];
            var resultMatrix = new int[3, 3];

            for (int row = 0; row < lenghtMatrix[0]; row++)
            {
                var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < lenghtMatrix[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var sum = 0;
            var targetRow = 0;
            var targetCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        targetRow = row;
                        targetCol = col;
                        
                    }
                }

            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = targetRow; i <= targetRow+2; i++)
            {
                for (int j = targetCol; j <= targetCol+2; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }

}