using System;
using System.Linq;

namespace OrangesApple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houseArea = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int s = houseArea[0];
            int t = houseArea[1];

            int[] treePositions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = treePositions[0];
            int b = treePositions[1];

            int[] distanceFromHouse = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = distanceFromHouse[0];
            int n = distanceFromHouse[1];

            int distanceOrr = b-t;
            int distanceApp = s-a;

            int[] apple = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int appleInHouse = 0;
            for (int i = 0; i < apple.Length; i++)
            {
                if (apple[i] < 0)
                {
                    continue;
                }
                else
                {
                    if (apple[i]>=distanceApp)
                    {
                        appleInHouse++;
                    }
                }
            }

            int[] orange = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int orangeInHouse = 0;
            for (int i = 0; i < orange.Length; i++)
            {
                if (orange[i] > 0)
                {
                    continue;
                }
                else
                {
                    if (orange[i] <= distanceOrr)
                    {
                        orangeInHouse++;
                    }
                }
            }
            Console.WriteLine(appleInHouse);
            Console.WriteLine(orangeInHouse);
        }
    }
}
