using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] counters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rectangles = new Dictionary<string, Rectangle>();

            for (int rectanglesCount = 0; rectanglesCount < counters[0]; rectanglesCount++)
            {
                string[] rectangleInfo = Console.ReadLine().Split();
                Rectangle rectangle = new Rectangle
                {
                    Id = rectangleInfo[0],
                    Width = double.Parse(rectangleInfo[1]),
                    Heigth = double.Parse(rectangleInfo[2]),
                    X = double.Parse(rectangleInfo[3]),
                    Y = double.Parse(rectangleInfo[4])
                };

                if (rectangles.ContainsKey(rectangle.Id) == false)
                {
                    rectangles.Add(rectangle.Id, rectangle);
                }
            }

            for (int intersectionsCount = 0; intersectionsCount < counters[1]; intersectionsCount++)
            {
                string[] ids = Console.ReadLine().Split();

                Console.WriteLine(rectangles[ids[0]].Intersection(rectangles[ids[1]]).ToString().ToLower());
            }
        }
    }
}