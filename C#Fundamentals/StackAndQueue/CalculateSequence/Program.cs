using System;
using System.Collections.Generic;

namespace CalculateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            Queue<int> currentQueue = new Queue<int>();

            queue.Enqueue(firstNum);
            currentQueue.Enqueue(firstNum);
            int s1 = firstNum;

            for (int i = 0; i <= 50; i++)
            {

                int n1 = s1 + 1;
                currentQueue.Enqueue(n1);
                queue.Enqueue(n1);
                int n2 = s1 * 2 + 1;
                currentQueue.Enqueue(n2);
                queue.Enqueue(n2);
                int n3 = s1 + 2;
                queue.Enqueue(n3);
                currentQueue.Enqueue(n3);

                currentQueue.Dequeue();
                s1 = currentQueue.Peek();
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.WriteLine();
        }
    }
}
