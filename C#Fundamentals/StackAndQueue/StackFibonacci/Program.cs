using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Stack<long> stackFib = new Stack<long>();

            stackFib.Push(0);
            stackFib.Push(1);
        
            

            for (int i = 1; i < n; i++)
            {
                long firstNumber = stackFib.Pop();
                long secondNumber = stackFib.Peek();

                stackFib.Push(firstNumber);
                stackFib.Push(firstNumber + secondNumber);
            }
            Console.WriteLine(stackFib.Peek());
        }
    }
}
