using System;
using System.Linq;
using System.Text;

namespace MatrixofPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[size[0], size[1]];

         

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char firstChar = alphabet[row];
                    char secondChar = alphabet[row + col];
                    char thirdChar = alphabet[row];
                    var text = string.Concat(firstChar, secondChar, thirdChar);
                    Console.Write($"{text} ");
                }
                Console.WriteLine();
            }
        }
    }
}
