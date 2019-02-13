using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of contests")
                    break;
                FillContest(input, passwords);
            }
            
            Dictionary<string, Dictionary<string, int>> members = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of submissions")
                    break;
                FillUsers(members, input, passwords,result);
            }

            PrintLeader(result);
            PrintRanking(members);
        }

        private static void PrintLeader(Dictionary<string, int> result)
        {
            foreach (var use in result)
            {
                var resultLeader = result.Values.Max();
                if (use.Value==resultLeader)
                {
                    Console.WriteLine($"Best candidate is {use.Key} with total {resultLeader} points.");
                    break;
                }
                
            }
            
        }

        private static void PrintRanking(Dictionary<string, Dictionary<string, int>> members)
        {
            Console.WriteLine("Ranking: ");
            foreach (var member in members.OrderBy(m=>m.Key))
            {
                Console.WriteLine($"{member.Key}");
                foreach (var contest in member.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        private static void FillUsers(Dictionary<string, Dictionary<string, int>> members, string input, Dictionary<string, string> passwords, Dictionary<string, int> result)
        {
            var info = input
                    .Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            var contest = info[0];
            var member = info[2];
            var points = int.Parse(info[3]);

            if (passwords.ContainsKey(info[0]) && passwords.ContainsValue(info[1]))
            {
                if (members.ContainsKey(member) == false)
                {
                    members.Add(member, new Dictionary<string, int>());
                    result.Add(member, 0);
                }
                if (members[member].ContainsKey(contest) == false)
                {
                    members[member].Add(contest, points);
                    result[member] += points;
                }
                else
                {
                    if (members[member][contest] < points)
                    {
                        members[member][contest] = points;
                        result[member] += points;
                    }
                    
                }                
            }
        }

        private static void FillContest(string input, Dictionary<string, string> passwords)
        {
            var contests = input
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var contest = contests[0];
            var pass = contests[1];

            if (passwords.ContainsKey(contest) == false)
            {
                passwords.Add(contest, "");
            }
            passwords[contest] = pass;
        }
    }
}
