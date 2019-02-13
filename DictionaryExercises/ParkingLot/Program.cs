using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];

            var parking = new Dictionary<int, List<int>>();

            for (int row = 0; row < rows; row++)
            {
                parking.Add(row, new List<int>() { 0});
            }
            var input = Console.ReadLine();
            
            while (input != "stop")
            {
                var coordinates = input.Split().Select(int.Parse).ToArray();

                var startingRow = coordinates[0];
                var targetRow = coordinates[1];
                var targetCol = coordinates[2];

                if (parking[targetRow].Contains(targetCol) == false)
                {
                    parking[targetRow].Add(targetCol);

                    int distance = Math.Abs(startingRow - targetRow) + targetCol+1;
                    Console.WriteLine(distance);
                }
                else if (parking[targetRow].Count == cols)
                {
                    Console.WriteLine($"Row {targetRow} full");
                }
                else
                {
                    var counter = 1;
                    
                    while (true)
                    {
                        var steps = targetCol - counter;
                        if (!parking[targetRow].Contains(steps) && steps > 0)
                        {
                            parking[targetRow].Add(steps);

                            int totalSteps = (startingRow - targetRow) + steps + 1;
                            Console.WriteLine(totalSteps);
                            break;
                        }
                        steps = targetCol + counter;
                        if (!parking[targetRow].Contains(steps) && steps < cols)
                        {
                            parking[targetRow].Add(steps);
                            int totalSteps = (startingRow - targetRow) + steps + 1;
                            Console.WriteLine(totalSteps);
                            break;
                        }
                        counter++;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
