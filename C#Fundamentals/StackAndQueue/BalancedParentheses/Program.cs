using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            var arrRight = new char[] { ')', ']', '}' };
            var arrLeft = new char[] { '(', '[', '{' };

            
            Stack<char> stack = new Stack<char>();


            bool isEqual = false;

            foreach (var element in input)
            {
                if (arrLeft.Contains(element))
                {
                    stack.Push(element);
                }
                else if(arrRight.Contains(element))
                {
                    var lastElement = stack.Pop();
                    var indexStart = Array.IndexOf(arrLeft, lastElement);
                    var indexEnd = Array.IndexOf(arrRight, element);

                    if (indexStart!=indexEnd)
                    {
                        Console.WriteLine("NO");
                        isEqual = false;
                        break;
                    }
                    else
                    {
                        isEqual = true;
                    }
                }
            }

            if (isEqual!=false)
            {
                Console.WriteLine("YES");
            }


        }
    }
}
