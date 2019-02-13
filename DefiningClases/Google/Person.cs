using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Child> Children
        {
            get { return children; }
            set { children = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public Person()
        {
            pokemons = new List<Pokemon>();
            parents = new List<Parent>();
            children = new List<Child>();
        }

        public Person(string name) : this()
        {
            this.name = name;
        }

        public void ChangeCompany(Company company)
        {
            this.company = company;
        }

        public void ChangeCar(Car car)
        {
            this.car = car;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public void AddParent(Parent parent)
        {
            parents.Add(parent);
        }

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public override string ToString()
        {
            string line = Environment.NewLine;
            string pokemonLine = (pokemons.Count > 0) ? Environment.NewLine : "";
            string parentsLine = (parents.Count > 0) ? Environment.NewLine : "";
            string childrenLine = (children.Count > 0) ? Environment.NewLine : "";

            return $"{Name}{line}" +
                $"Company:{company}{line}" +
                $"Car:{car}{line}" +
                $"Pokemon:{pokemonLine}{string.Join(Environment.NewLine, pokemons)}{line}" +
                $"Parents:{parentsLine}{string.Join(Environment.NewLine, parents)}{line}" +
                $"Children:{childrenLine}{string.Join(Environment.NewLine, children)}";
        }
    }
}