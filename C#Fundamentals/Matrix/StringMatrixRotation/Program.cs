using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine()
                .Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var degrees = int.Parse(command[1]);

            while (degrees > 360)
            {
                degrees -= 360;
            }

            List<string> list = new List<string>();

            while (true)
            {
                var token = Console.ReadLine();
                if (token == "END")
                    break;
                list.Add(token);
            }

            var arr = new string[list.Count][];
            if (degrees == 0||degrees==360)
            {
                for (int row = 0; row < arr.Length; row++)
                {
                    Console.WriteLine(list[row]);
                }
            }
            else if (degrees == 90)
            {

                var maxLenght = list.Select(x => x.Length).Max();
                var matrix = new char[maxLenght, list.Count];

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var words = list[list.Count - 1 - col].ToCharArray();

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        if (row < words.Length)
                        {
                            matrix[row, col] = words[row];
                        }
                        else
                        {
                            matrix[row, col] = ' ';
                        }
                    }
                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degrees == 180)
            {
                for (int row = arr.Length - 1; row >= 0; row--)
                {
                    var reversed = list[row].Reverse();
                    Console.WriteLine(string.Join("", reversed));
                }
            }
            else if (degrees == 270)
            {
                var maxLenght = list.Select(x => x.Length).Max();
                var matrix = new char[maxLenght, list.Count];
                var counter = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var words = list[col].ToCharArray();

                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        if (row > maxLenght - words.Length - 1)
                        {
                            matrix[row, col] = words[counter];
                            counter++;
                        }
                        else
                        {
                            matrix[row, col] = ' ';
                        }
                    }
                    counter = 0;
                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
