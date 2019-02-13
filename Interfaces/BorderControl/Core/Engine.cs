using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl.Core
{
    public class Engine
    {
        Dictionary<string, IBuyer> creatures;
        public Engine()
        {
            this.creatures = new Dictionary<string, IBuyer>();
        }
        public void Run()
        {
            var count = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                
                var tokens = input.Split();
                if (creatures.ContainsKey(tokens[0]) == false)
                {
                    if (tokens.Length == 3)
                    {
                        FillRebel(tokens);
                    }
                    else
                    {
                        FillCitizens(tokens);
                    }
                }
                input = Console.ReadLine();
            }

            var command = input;
            var totalFood = 0;

            while (command != "End")
            {
                foreach (var creature in creatures.Where(x=>x.Key==command))
                {
                    totalFood += creature.Value.BuyFood();
                }
              command = Console.ReadLine();
            }
            Console.WriteLine(totalFood);
        }
        private void FillCitizens(string[] tokens)
        {
            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var id = tokens[2];
            var birthday = tokens[3];

            IBuyer citizen = new Citizen(name, age, id, birthday);
            creatures.Add(name, citizen);
        }

        private void FillRebel(string[] tokens)
        {
            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var group = tokens[2];

            IBuyer rebel = new Rebel(name, age, group);
            creatures.Add(name, rebel);
        }


    }
}
