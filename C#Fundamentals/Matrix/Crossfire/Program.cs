using System;

using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    public class Program
    {
    
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];
            var counter = 0;

            var list = new List<List<int>>();

            for (int row = 0; row < rows; row++)
            {
                var listRow = new List<int>();
                for (int col = 0; col < cols; col++)
                {
                    counter++;
                    listRow.Add(counter);
                }
                list.Add(listRow);
            }

            var input = Console.ReadLine();
            while (input != "Nuke it from orbit")
            {
                var token = input.Split().Select(int.Parse).ToArray();

                var rowImpact = token[0];
                var colImpact = token[1];
                var radius = token[2];


                for (int row = 0; row < list.Count; row++)
                {
                    for (int col = 0; col < list[row].Count; col++)
                    {
                        if ((row == rowImpact && Math.Abs(col - colImpact) <= radius) ||
                           (col == colImpact && Math.Abs(row - rowImpact) <= radius))
                        {
                            list[row][col] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
                for (int row = 0; row < list.Count; row++)
                {
                    list[row].RemoveAll(x => x == 0);
                    if (list[row].Count == 0)
                    {
                        list.RemoveAt(row);
                        row--;
                    }

                }
            }
            
            for (int row = 0; row < list.Count; row++)
            {
                Console.WriteLine(string.Join(" ", list[row]));
            }

        }
    }
}
