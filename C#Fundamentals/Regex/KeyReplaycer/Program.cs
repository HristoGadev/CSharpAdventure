using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KeyReplaycer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStartEndIndex = Console.ReadLine();
            Regex regexIndex = new Regex(@"([A-Za-z]+)(<|\|)(.*)(<|\|)([A-Za-z]+)");
            MatchCollection indexMatches = regexIndex.Matches(inputStartEndIndex);

            var startIndex = "";
            var endIndex = "";
            foreach (Match match in indexMatches)
            {
                 startIndex = match.Groups[1].Value;
                 endIndex = match.Groups[5].Value;
            }
            
            var stringInput = Console.ReadLine();
            var stringPattern = $@"{startIndex}(.*?){endIndex}";
            Regex regexString = new Regex(stringPattern);
            MatchCollection stringMacthes = regexString.Matches(stringInput);

            List<string> result = new List<string>();

            foreach (Match match in stringMacthes)
            {
                var resultMatch = match.Groups[1].Value;
                result.Add(resultMatch);
                
            }
            foreach(var elem in result)
            {
                if (elem == string.Empty)
                {
                    Console.WriteLine("Empty result");
                    return;
                }
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
