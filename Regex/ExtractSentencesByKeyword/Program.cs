using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordToFind = Console.ReadLine();
            var pattern = $@"\b{wordToFind}\b";

            Regex regex = new Regex(pattern);
            var input = Console.ReadLine()
                .Split(new [] { '.','!','?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in input)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
