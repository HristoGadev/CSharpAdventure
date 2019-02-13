using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int [lenght[0],lenght[1]];

            int sum = 0;

            for (int row  = 0; row < matrix.GetLength(0); row++)
            {
                var numbers= Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                    sum += matrix[row,col];
                }
            }
            Console.WriteLine(lenght[0]);
            Console.WriteLine(lenght[1]);
            Console.WriteLine(sum);
        }
    }
}
