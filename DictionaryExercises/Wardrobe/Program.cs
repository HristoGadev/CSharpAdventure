using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colours = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("->").ToArray();

                var colour = input[0];
                var clothes = input[1].Trim();

                if (colours.ContainsKey(colour) == false)
                {
                    colours.Add(colour, new Dictionary<string, int>());

                    var clothesCollection = clothes.Split(",").ToArray();
                    foreach (var cloth in clothesCollection)
                    {
                        cloth.Trim();
                        if (colours[colour].ContainsKey(cloth.Trim()) == false)
                        {
                            colours[colour].Add(cloth, 0);
                        }
                        colours[colour][cloth] += 1;
                    }
                }
                else
                {
                    var clothesCollection = clothes.Split(",").ToArray();
                    foreach (var cloth in clothesCollection)
                    {
                        cloth.Trim();
                        if (colours[colour].ContainsKey(cloth.Trim()) == false)
                        {
                            colours[colour].Add(cloth, 0);
                        }
                        colours[colour][cloth] += 1;
                    }
                }
            }
            var searchedDress = Console.ReadLine().Split();

            var searchedColour = searchedDress[0];
            var searchedCloth = searchedDress[1];

            foreach (var colour in colours)
            {
                if (colour.Key.Trim() == searchedColour.Trim())
                {
                    Console.WriteLine($"{colour.Key.Trim()} clothes:");
                    foreach (var clot in colour.Value)
                    {
                        if (clot.Key.Trim() == searchedCloth.Trim())
                        {
                            Console.WriteLine($"* {clot.Key.Trim()} - {clot.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {clot.Key.Trim()} - {clot.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{colour.Key.Trim()} clothes:");
                    foreach (var clot in colour.Value)
                    {
                        Console.WriteLine($"* {clot.Key.Trim()} - {clot.Value}");
                    }
                }
            }
        }
    }
}
