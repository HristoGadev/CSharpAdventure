using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            {
                var input = Console.ReadLine().ToCharArray();

                if (input.Length % 2 != 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                var arrRight = new char[] { ')', ']', '}' };
                var arrLeft = new char[] { '(', '[', '{' };

                Stack<char> stack = new Stack<char>();

                foreach (var element in input)
                {
                    if (arrLeft.Contains(element))
                    {
                        stack.Push(element);
                    }
                    else if (arrRight.Contains(element))
                    {
                        var lastElement = stack.Pop();
                        var indexStart = Array.IndexOf(arrLeft, lastElement);
                        var indexEnd = Array.IndexOf(arrRight, element);

                        if (indexStart != indexEnd)
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                    }
                }
            }
        }
    }
}
