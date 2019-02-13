using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = inputArgs[0];
                string inputType = inputArgs[1];
                Person person = new Person(personName);

                if (people.ContainsKey(personName) == false)
                {
                    people.Add(personName, person);
                }

                switch (inputType)
                {
                    case "company":
                        string companyName = inputArgs[2];
                        string department = inputArgs[3];
                        decimal salary = decimal.Parse(inputArgs[4]);
                        Company company = new Company(companyName, department, salary);
                        people[personName].ChangeCompany(company);
                        break;
                    case "pokemon":
                        string pokemonName = inputArgs[2];
                        string pokemonType = inputArgs[3];
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                        people[personName].AddPokemon(pokemon);
                        break;
                    case "parents":
                        string parentName = inputArgs[2];
                        string parentBirthday = inputArgs[3];
                        Parent parent = new Parent(parentName, parentBirthday);
                        people[personName].AddParent(parent);
                        break;
                    case "children":
                        string childName = inputArgs[2];
                        string childBirthday = inputArgs[3];
                        Child child = new Child(childName, childBirthday);
                        people[personName].AddChild(child);
                        break;
                    case "car":
                        string carModel = inputArgs[2];
                        int carSpeed = int.Parse(inputArgs[3]);
                        Car car = new Car(carModel, carSpeed);
                        people[personName].ChangeCar(car);
                        break;
                }
            }

            string name = Console.ReadLine();

            Console.WriteLine(people[name]);
        }
    }
}