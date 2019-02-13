using System;
using System.Collections.Generic;
using System.Linq;

namespace MutantBunnies
{
    public class Program
    {
        static int playerRow;
        static int playerCol;
        static char[][] jaggedArr;
        static bool isOutside;
        static bool isDead;
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            jaggedArr = new char[rows][];

            FillJagged(cols);

            var directions = Console.ReadLine().ToCharArray();
            MovePlayer(directions);
        }

        private static void MovePlayer(char[] directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                char currentStep = directions[i];

                if (currentStep == 'U')
                {
                    Move(-1, 0);
                }
                else if (currentStep == 'L')
                {
                    Move(0, -1);
                }
                else if (currentStep == 'R')
                {
                    Move(0, 1);
                }
                else if (currentStep == 'D')
                {
                    Move(1, 0);
                }
                SpreadBunny();

                if (isDead)
                {
                    PrintJagged();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    isDead = true;
                    break;
                }
                if (isOutside)
                {
                    jaggedArr[playerRow][playerCol] = '.';
                    PrintJagged();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    isOutside = true;
                }
            }
        }

        private static void PrintJagged()
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                Console.WriteLine(string.Join("", jaggedArr[row]));
            }
        }

        private static void SpreadBunny()
        {
            Queue<int[]> indexes = new Queue<int[]>();
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    if (jaggedArr[row][col] == 'B')
                    {
                        indexes.Enqueue(new int[] { row, col });
                    }
                }
            }
            while (indexes.Count > 0)
            {
                var currentIndexes = indexes.Dequeue();

                var currentRow = currentIndexes[0];
                var currentCol = currentIndexes[1];

                if (IsInside(currentRow - 1, currentCol))
                {
                    if (IsPlayer(currentRow - 1, currentCol))
                    {
                        isDead = true;
                    }
                    jaggedArr[currentRow - 1][currentCol] = 'B';
                }
                if (IsInside(currentRow + 1, currentCol))
                {
                    if (IsPlayer(currentRow + 1, currentCol))
                    {
                        isDead = true;
                    }
                    jaggedArr[currentRow + 1][currentCol] = 'B';
                }
                if (IsInside(currentRow, currentCol + 1))
                {
                    if (IsPlayer(currentRow, currentCol + 1))
                    {
                        isDead = true;
                    }
                    jaggedArr[currentRow][currentCol + 1] = 'B';
                }
                if (IsInside(currentRow, currentCol - 1))
                {
                    if (IsPlayer(currentRow, currentCol - 1))
                    {
                        isDead = true;
                    }
                    jaggedArr[currentRow][currentCol - 1] = 'B';
                }
            }
        }

        private static bool IsPlayer(int row, int col)
        {
            return jaggedArr[row][col] == 'P';
        }

        private static void Move(int row, int col)
        {
            var targetRow = playerRow + row;
            var targetCol = playerCol + col;

            if (!IsInside(targetRow, targetCol))
            {
                jaggedArr[playerRow][playerCol] = '.';
                isOutside = true;
            }
            else if (IsBunny(targetRow, targetCol))
            {
                jaggedArr[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                isDead = true;

            }
            else
            {
                jaggedArr[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                jaggedArr[playerRow][playerCol] = 'P';
            }
        }
        private static bool IsBunny(int targetRow, int targetCol)
        {
            return jaggedArr[targetRow][targetCol] == 'B';
        }
        private static bool IsInside(int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < jaggedArr.Length && targetCol >= 0 && targetCol < jaggedArr[targetRow].Length;
        }
        private static void FillJagged(int cols)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                jaggedArr[row] = new char[cols];
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    jaggedArr[row][col] = input[col];
                    if (input[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
