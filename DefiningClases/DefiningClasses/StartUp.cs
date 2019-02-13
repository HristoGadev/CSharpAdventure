using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                Person person = new Person(name, age);
                persons.Add(person);
            }
            foreach (var member in persons.OrderBy(x => x.Name).Where(a => a.Age > 30))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
