using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                queue.Enqueue(input);
            }

            var index = 0;
            while (true)
            {
                int totalFuel = 0;

                foreach (var pump in queue)
                {
                    var pumpFuel = pump[0];
                    var pumpDistance = pump[1];


                    totalFuel += pumpFuel - pumpDistance;

                    if (totalFuel < 0)
                    {
                        index++;
                        var pumpToRemove = queue.Dequeue();
                        queue.Enqueue(pumpToRemove);
                        break;
                        
                    }
                }
                if (totalFuel>=0)
                {
                    break;
                }
            }
            Console.WriteLine(index);

        }
    }
}
