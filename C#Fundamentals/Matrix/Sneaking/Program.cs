using System;
using System.Linq;

namespace Sneaking
{
    class Program
    {
        //FindPlayers
        //MovementPlayers
        //Win
        //Die
        //PrintMatrix

        static char[,] board;



        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            board = FillMatrix(lenght);
            Console.WriteLine();


        }

        private static char[,] FillMatrix(int lenght)
        {
            var input = Console.ReadLine()
                    .ToCharArray();

            var matrix = new char[lenght, input.Length];

            for (int row = 0; row < lenght; row++)
            {
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }

                input = Console.ReadLine()
                   .ToCharArray();
            }

            return matrix;
        }
    }
}
