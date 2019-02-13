using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>();
            Queue<int> locks = new Queue<int>();

            var bulletsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locksInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int valueIntelligence = int.Parse(Console.ReadLine());

            for (int i = 0; i < bulletsInfo.Length; i++)
            {
                bullets.Push(bulletsInfo[i]);
            }
            for (int j = 0; j < locksInfo.Length; j++)
            {
                locks.Enqueue(locksInfo[j]);
            }

            int countShots = 0;


            while (true)
            {
                if (locks.Count < 1 || bullets.Count < 1)
                {
                    break;
                }
                countShots++;

                var currentBullet = bullets.Pop();
                var currentLock = locks.Peek();

                if (currentBullet > currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                if (countShots % sizeBarrel == 0)
                {
                    if (bullets.Count < 1)
                    {
                        break;
                    }
                    Console.WriteLine("Reloading!");
                }

            }

            var bulletsLeft = bullets.Count;
            var locksLeft = locks.Count;
            var moneyEarned = valueIntelligence - (countShots * bulletPrice);

            if (locks.Count < 1)
            {
                Console.WriteLine($"{ bulletsLeft} bullets left. Earned ${moneyEarned}");

            }
            else if (bullets.Count < 1)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }

        }
    }
}
