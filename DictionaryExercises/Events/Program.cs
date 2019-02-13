using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var pattern = @"^#([A-Za-z]+):[ ]*@([A-Za-z]+)[ ]*([0-9]+:[0-9]+)$";
            Regex regex = new Regex(pattern);
            var events = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var name = match.Groups[1].Value;
                    var city = match.Groups[2].Value;
                    var time = match.Groups[3].Value;
                    var timesplit = time.Split(new[]{':'},StringSplitOptions.RemoveEmptyEntries);
                    var hours =int.Parse( timesplit[0]);
                    var minutes = int.Parse(timesplit[1]);
                    if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
                    {
                        break;
                    }
                 
                    if (events.ContainsKey(city)==false)
                    {
                        events.Add(city, new Dictionary<string, List<string>>());
                    }
                    if (events[city].ContainsKey(name)==false)
                    {
                        events[city].Add(name, new List<string>());

                    }
                    events[city][name].Add(time);

                }
           
            }
            var text = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var counter = 0;
            foreach (var even in events.OrderBy(e=>e.Key))
            {
                if (text.Contains(even.Key))
                {
                    Console.WriteLine($"{even.Key}:");

                    foreach (var name in even.Value.OrderBy(n=>n.Key))
                    {
                        var resultInfo = name.Value.OrderBy(n => n);
                        counter++;
                                            
                        Console.WriteLine($"{counter}. {name.Key} -> {string.Join(", ",resultInfo)}");
                    }
                    counter = 0;
                }
            }


        }
    }
}
