using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"({[^\[\]\{\}\d]*(\d{3,})[^\[\]\{\}\d]*})|(\[[^\[\]\{\}\d]*(\d{3,})[^\[\]\{\}\d]*\])";
            int lines = int.Parse(Console.ReadLine());

            Regex regex = new Regex(pattern);
            var input = "";
            for (int i = 0; i < lines; i++)
            {
                 input += Console.ReadLine();
            }
            

            MatchCollection matches = regex.Matches(input);
            Queue<int> numbersFirstBlock = new Queue<int>();
            

            foreach (Match match  in matches)
            {
                var lenghtBlockFirst = match.Groups[1].Value.Length;
                var textBlockFirst = match.Groups[2].Value;

                for (int i = 0; i <= textBlockFirst.Length; i++)
                {
                    numbersFirstBlock.Enqueue(int.Parse(textBlockFirst.Substring(0,3))-lenghtBlockFirst);
                   var a= textBlockFirst.Substring(3);
                }
                
                var lenghtBlockSecond = match.Groups[3].Value.Length;
                var textBlockSecond = match.Groups[4].Value;

                for (int i = 0; i <= textBlockFirst.Length; i++)
                {
                    numbersFirstBlock .Enqueue(int.Parse(textBlockSecond.Substring(0, 3))-lenghtBlockSecond);
                    textBlockSecond = textBlockSecond.Remove(0, 3);
                }
            }
            Console.WriteLine();
        }
    }
}
