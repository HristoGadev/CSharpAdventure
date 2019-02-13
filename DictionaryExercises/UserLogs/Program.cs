using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //user,ip
            var users = new Dictionary<string, string>();
            //ip,count
            var ipCount = new Dictionary<string, int>();


            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                    break;

                var token = input.Split().ToArray();

                var iPAdress = token[0];
                var user = token[2];

                var ipArr = iPAdress.Split("=").ToArray();
                var ip = ipArr[1];
                var usernameArr = user.Split("=").ToArray();
                var username = usernameArr[1];

                var counter = 1;
                if (users.ContainsKey(username) == false)
                {
                    users.Add(username, ip);
                }
                if (ipCount.ContainsKey(ip) == false)
                {
                    
                    ipCount.Add(ip, counter);
                }
                else
                {
                    counter++;
                    ipCount[ip] = counter;
                }
                
               
            }
            foreach (var use in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{use.Key}:");

                foreach (var ips in ipCount)
                {
                    Console.WriteLine($"{ips.Key} => {ips.Value}");
                }
            }

        }
    }
}
