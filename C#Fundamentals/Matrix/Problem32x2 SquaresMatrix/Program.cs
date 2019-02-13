using System;
using System.Linq;

namespace Problem32x2_SquaresMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtMatrix = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[lenghtMatrix[0], lenghtMatrix[1]];

            for (int row = 0; row < lenghtMatrix[0]; row++)
            {
                var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                for (int col = 0; col < lenghtMatrix[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] && 
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
