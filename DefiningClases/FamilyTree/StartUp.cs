using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var wantedPersonInfo = Console.ReadLine();
            var inputs = new List<string>();
            var people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-"))
                {
                    inputs.Add(input);
                }
                else
                {
                    string[] personInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = $"{personInfo[0]} {personInfo[1]}";
                    string birthday = personInfo[2];
                    Person person = new Person(name, birthday);
                    people.Add(person);
                }
            }

            foreach (string tie in inputs)
            {
                string[] tieInfo = tie.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string parentInfo = tieInfo[0].Trim();
                string childInfo = tieInfo[1].Trim();
                Person parent = GetPerson(people, parentInfo);
                Person child = GetPerson(people, childInfo);
                parent.AddChild(child);
                child.AddParent(parent);
            }

            Person wantedPerson = GetPerson(people, wantedPersonInfo);

            Console.WriteLine(wantedPerson);
            Console.WriteLine("Parents:");

            if (wantedPerson.Parents.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, wantedPerson.Parents));
            }

            Console.WriteLine("Children:");

            if (wantedPerson.Children.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, wantedPerson.Children));
            }
        }

        private static Person GetPerson(List<Person> people, string tieInfo)
        {
            Person person;
            if (tieInfo.Contains("/"))
            {
                person = people.First(p => p.Birthday == tieInfo);
            }
            else
            {
                person = people.First(p => p.Name == tieInfo);
            }

            return person;
        }
    }
}