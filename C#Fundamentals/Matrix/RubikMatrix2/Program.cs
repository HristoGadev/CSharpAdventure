using System;
using System.Linq;

namespace RubikMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];

            int[][] rubikMatrix = new int[rows][];

            FillMatrix(rubikMatrix, cols);

            var countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var element = int.Parse(input[0]);
                var direction = input[1];
                var radius = int.Parse(input[2]);
                var movesRows = radius % rubikMatrix[0].Length;
                var movesCols = radius % rubikMatrix.Length;

                switch (direction)
                {
                    case "down":
                        MoveElemntDown(rubikMatrix, movesCols, element);
                        break;
                    case "up":
                        MoveElementUp(rubikMatrix, movesCols, element);
                        break;
                    case "left":
                        MoveElementLeft(rubikMatrix, movesRows, element);
                        break;
                    case "right":
                        MoveElementRight(rubikMatrix, movesRows, element);
                        break;
                }
            }
            var counter = 1;
            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                for (int col = 0; col < rubikMatrix[row].Length; col++)
                {
                    if (rubikMatrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;

                    }
                    else
                    {
                        RearangeRubikMatrix(rubikMatrix, row, col, counter);
                        counter++;
                    }
                }

            }
        }

        private static void RearangeRubikMatrix(int[][] rubikMatrix, int row, int col, int counter)
        {
            for (int indexRow = 0; indexRow < rubikMatrix.Length; indexRow++)
            {
                for (int indexCol = 0; indexCol < rubikMatrix[indexRow].Length; indexCol++)
                {
                    if (rubikMatrix[indexRow][indexCol] == counter)
                    {
                        rubikMatrix[indexRow][indexCol] = rubikMatrix[row][col];
                        rubikMatrix[row][col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({indexRow}, {indexCol})");
                        return;
                    }
                }
            }
        }

        private static void MoveElementRight(int[][] rubikMatrix, int moves, int row)
        {
            for (int i = 0; i < moves; i++)
            {
                var lastElement = rubikMatrix[row][rubikMatrix[row].Length - 1];
                for (int col = rubikMatrix[row].Length-1; col > 0; col--)
                {
                    rubikMatrix[row][col] = rubikMatrix[row][col - 1];
                }
                rubikMatrix[row][0] = lastElement;
            }

        }

        private static void MoveElementLeft(int[][] rubikMatrix, int moves, int row)
        {
            for (int i = 0; i < moves; i++)
            {
                var firstElement = rubikMatrix[row][0];
                for (int col = 0; col < rubikMatrix[row].Length - 1; col++)
                {
                    rubikMatrix[row][col] = rubikMatrix[row][col + 1];
                }
                rubikMatrix[row][rubikMatrix[row].Length - 1] = firstElement;
            }

        }
        private static void MoveElementUp(int[][] rubikMatrix, int moves, int col)
        {
            for (int i = 0; i < moves; i++)
            {
                var firstElement = rubikMatrix[0][col];
                for (int row = 0; row < rubikMatrix.Length - 1; row++)
                {
                    rubikMatrix[row][col] = rubikMatrix[row + 1][col];
                }
                rubikMatrix[rubikMatrix.Length - 1][col] = firstElement;
            }

        }
        private static void MoveElemntDown(int[][] rubikMatrix, int moves, int col)
        {
            for (int i = 0; i < moves; i++)
            {
                var lastElement = rubikMatrix[rubikMatrix.Length - 1][col];
                for (int row = rubikMatrix.Length - 1; row > 0; row--)
                {
                    rubikMatrix[row][col] = rubikMatrix[row - 1][col];

                }
                rubikMatrix[0][col] = lastElement;
            }

        }
        private static void FillMatrix(int[][] rubikMatrix, int cols)
        {
            var counter = 1;
            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                rubikMatrix[row] = new int[cols];
                for (int col = 0; col < rubikMatrix[row].Length; col++)
                {
                    rubikMatrix[row][col] = counter;
                    counter++;
                }
            }
        }
    }
}
