using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitList
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetIndex = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> persons = new Dictionary<string, List<string>>();
            

            var input = Console.ReadLine();

            while (input != "end transmissions")
            {
                var tokenPerson = input.Split(new char[] { '=',';'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokenPerson[0];
                var info = tokenPerson[1];
               

                if (persons.ContainsKey(name)==false)
                {
                    persons.Add(name, new List<string>());
                }
                persons[name].Add(info);

                if (tokenPerson.Length>2)
                {
                    for (int i = 2; i < tokenPerson.Length; i++)
                    {
                        var info2 = tokenPerson[i];
                        persons[name].Add(info2);
                    }
                    
                }

                input = Console.ReadLine();
            }

            var inputName = Console.ReadLine().Split();
            var namePerson = inputName[1];

            foreach (var person in persons)
            {
                if (namePerson==person.Key)
                {
                    Console.WriteLine($"Info on {person.Key}:");

                    var valueLenght = 0;
           
                    foreach (var personInfo in person.Value.OrderBy(x=>x))
                    {
                        var splitedPerson = personInfo.Split(":");
                        var resultPersonInfo = string.Join(": ", splitedPerson);
                        Console.WriteLine($"---{resultPersonInfo}");
                        valueLenght += personInfo.Length;
                    }

                    var indexLenght = valueLenght - person.Value.Count;
                    var neededIndex = targetIndex - indexLenght;

                    Console.WriteLine($"Info index: {indexLenght}");
                    if (indexLenght>targetIndex)
                    {
                        Console.WriteLine("Proceed");
                    }
                    else
                    {
                        Console.WriteLine($"Need {neededIndex} more info.");
                    }
                }
            }
        }
    }
}
