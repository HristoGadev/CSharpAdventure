using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int push = commands[0];
            int pop = commands[1];
            int containsNumber = commands[2];

            var input= Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < push; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();

            }
            if (stack.Contains(containsNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
