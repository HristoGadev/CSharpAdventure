using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int commands = input[0];

                switch (commands)
                {
                    case 1:
                        var number = input[1];
                        stack.Push(input[1]);
                        if (number >= maxStack.Peek())
                        {
                            maxStack.Push(number);
                        }
                        break;
                    case 2:
                        var poppedElemnet = stack.Pop();
                        if (maxStack.Peek() == poppedElemnet)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElemnt = maxStack.Peek();
                        Console.WriteLine(maxElemnt);
                        break;

                }
            }


        }
    }
}
