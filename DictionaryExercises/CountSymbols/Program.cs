using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToCharArray();

            Dictionary<char, int> wordsCount = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (wordsCount.ContainsKey(currentWord)==false)
                {
                    wordsCount.Add(currentWord, 0);
                }
                wordsCount[currentWord] += 1;
            }
            foreach (var word in wordsCount.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{word.Key}: {word.Value} time/s");
            }
        }
    }
}
