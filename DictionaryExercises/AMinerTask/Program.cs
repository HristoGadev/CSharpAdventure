using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> miner= new Dictionary<string, int>();

            var counter = 0;
            
            var resource = "";

            while (true)
            {
                counter++;
                var quantity = 0;
                var input = Console.ReadLine();

                if (input == "stop")
                    break;

                if (counter % 2 == 0)
                {
                    quantity = int.Parse(input);
                }
                else if (counter % 2 != 0)
                {
                    resource = input;
                }
                if (miner.ContainsKey(resource)==false)
                {
                    miner.Add(resource, quantity);
                }
                else
                {
                    miner[resource] += quantity;
                }
            }
            foreach (var mine in miner)
            {
                Console.WriteLine($"{mine.Key} -> {mine.Value}");
            }
        }
    }
}
