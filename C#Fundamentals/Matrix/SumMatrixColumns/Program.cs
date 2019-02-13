using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];

            var sumCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }

            }
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sumCol += matrix[r, c];
                }
                Console.WriteLine(sumCol);
                sumCol = 0;
            }
   
               
        }
    }
}
