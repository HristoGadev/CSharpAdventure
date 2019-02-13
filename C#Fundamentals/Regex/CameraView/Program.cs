using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var startIndex = lenght[0];
            var endIndex = lenght[1];
         

            var pattern = @"\|<(\w+)";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            var resultWords = new Queue<string>();
            foreach (Match match in matches)
            {
                var selectedMatch = match.Groups[1].Value;
                var result = selectedMatch.Skip(startIndex).Take(endIndex).ToArray();
                var currentResult = string.Join("", result);
                resultWords.Enqueue(currentResult);
            }

            Console.Write(string.Join(", ", resultWords));
            Console.WriteLine();
        }
    }
}
