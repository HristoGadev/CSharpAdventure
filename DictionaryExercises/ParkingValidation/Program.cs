using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParkingValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[A-Z]{2}[0-9]{4}[A-Z]{2}";


            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                var commands = input[0];
                var name = input[1];
                var licensePlate = "";

                if (input.Length > 2)
                {
                    licensePlate = input[2];
                }

                var match = Regex.IsMatch(licensePlate, pattern);

                if (match)
                {
                    if (commands == "register")
                    {
                        if (parkingUsers.Any(x => x.Value == licensePlate))
                        {
                            Console.WriteLine($"ERROR: license plate { licensePlate} is busy");
                            continue;
                        }
                        if (parkingUsers.ContainsKey(name) == false)
                        {
                            parkingUsers.Add(name, licensePlate);
                            Console.WriteLine($"{ name} registered { licensePlate} successfully");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number { licensePlate}");
                            continue;
                        }
                        
                    }
                }
                else
                {
                    if (commands == "unregister")
                    {
                        if (parkingUsers.ContainsKey(name) == false)
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }

                        else if (parkingUsers.ContainsKey(name))
                        {
                            Console.WriteLine($"user { name} unregistered successfully");
                            parkingUsers.Remove(name);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                    }
                }

            }

            foreach (var user in parkingUsers)
            {
                var userName = user.Key;
                var licenseNumber = user.Value;
                Console.WriteLine($"{userName} => {licenseNumber}");
            }
        }

    }
}
