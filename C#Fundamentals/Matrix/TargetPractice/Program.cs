using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetPractice
{
    public static class TargetPractice
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = ReadAndFillMatrix(size);

            var shotParam = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            var impactRow = shotParam[0];
            var impactCol = shotParam[1];
            var radius = shotParam[2];
            var pointHit = matrix[impactRow, impactCol];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row - impactRow) * (row - impactRow) + (col - impactCol) * (col - impactCol) <= radius * radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int colInside = 0; colInside < matrix.GetLength(1); colInside++)
                    {
                        if (matrix[row + 1, colInside] == ' ')
                        {
                            matrix[row + 1, colInside] = matrix[row, colInside];
                            matrix[row, colInside] = ' ';
                        }
                    }
                }
                
            }
         
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col< matrix.GetLength(1) ; col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }

        }

        private static char[,] ReadAndFillMatrix(int[] size)
        {
            var rows = size[0];
            var cols = size[1];
            var matrix = new char[rows, cols];

            var input = Console.ReadLine().ToCharArray();
            Queue<char> words = new Queue<char>();

            foreach (var item in input)
            {
                words.Enqueue(item);
            }

            var counter = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {

                if (counter % 2 == 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = words.Dequeue();
                        words.Enqueue(matrix[row, col]);
                    }
                }
                else
                {
                    for (int col = 0; col <= matrix.GetLength(1) - 1; col++)
                    {
                        matrix[row, col] = words.Dequeue();
                        words.Enqueue(matrix[row, col]);
                    }
                }
                counter++;

            }
            return matrix;
        }
    }
}
