using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string(' ',n-row)+new string('*',row));
            }
        }
    }
}
