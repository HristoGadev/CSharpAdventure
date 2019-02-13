using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] games = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] resultCount = new int[2];

            int maxTarget = games[0];
            int minTarget = games[0];




            for (int i = 1; i < games.Length; i++)
            {
                if (games[i] < minTarget)
                {

                    minTarget = games[i];
                    ++resultCount[1];
                }
                else if (games[i] > maxTarget)
                {

                    maxTarget = games[i];
                   ++resultCount[0];
                }
            }

            Console.WriteLine(string.Join(" ", resultCount));

        }
    }
}
