using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            var text = string.Empty;

            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var commands= input[0];
              
                switch (commands)
                {

                    case "1":
                        var currentString = input[1];
                        stack.Push(text);

                        text += currentString;
                        break;
                    case "2":
                        var elementToErase = int.Parse(input[1]);
                        if (elementToErase>text.Length)
                        {
                           elementToErase= Math.Min(elementToErase, text.Length);
                        }

                        stack.Push(text);
                        text = text.Substring(0, text.Length - elementToErase);
                        break;
                    case "3":
                        var index =int.Parse(input[1]);
                        var element = text[index - 1];
                        Console.WriteLine(element);
                        break;
                    case "4":
                        text = stack.Pop();
                        break;
                 
                }
            }
        }
    }
}
