using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var pattern = $@"({word})";
            var input = Console.ReadLine();
            Regex regex = new Regex(word);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var censoredlenght = match.Groups[1].Value.Length;
                var censored = new string('*', censoredlenght);
                
            }

        }
    }
}
