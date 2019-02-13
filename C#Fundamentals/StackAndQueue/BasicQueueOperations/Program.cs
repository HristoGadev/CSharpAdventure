using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int push = commands[0];
            int pop = commands[1];
            int containsNumber = commands[2];

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < push; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                queue.Dequeue();

            }
            if (queue.Contains(containsNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
