using System;

namespace FindSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[,] matrix = new char[number, number];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            var element = (char)Console.Read();
          
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == element)
                    {
                        Console.WriteLine($"({row}, {col})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{element} does not occur in the matrix");
         
       
        }
    }
}
