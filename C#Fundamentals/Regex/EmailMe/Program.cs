using System;
using System.Text.RegularExpressions;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(.*)@(.*)";
            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var leftLenght = match.Groups[1].Value.Length;
                var rightLenght = match.Groups[2].Value.Length;

                if (leftLenght-rightLenght<0)
                {
                    Console.WriteLine("She is not the one.");
                }
                else
                {
                    Console.WriteLine("Call her!");
                }
            }


        }
    }
}
