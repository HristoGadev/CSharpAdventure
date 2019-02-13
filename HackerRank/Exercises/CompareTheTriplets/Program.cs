using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var aliceProblem = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bobProblem= Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>() ;

            var alicePoints = 0;
            var bobPoints = 0;
           

            for (int i = 0; i < 3; i++)
            {
                if (aliceProblem[i] == bobProblem[i])
                {
                    continue;
                }
                else if (aliceProblem[i] > bobProblem[i])
                {
                    alicePoints++;
                }
                else if (aliceProblem[i] < bobProblem[i])
                {
                    bobPoints++;
                }

            }
            result.Add(alicePoints);
            result.Add(bobPoints);

            var resultArray=(string.Join(" ",result));
            Console.WriteLine(resultArray);
        }
    }
}
