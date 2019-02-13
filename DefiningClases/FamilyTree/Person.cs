using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        public Person()
        {
            parents = new List<Person>();
            children = new List<Person>();
        }

        public Person(string name, string birthday)
            : this()
        {
            this.name = name;
            this.birthday = birthday;
        }

        public void AddChild(Person person)
        {
            children.Add(person);
        }

        public void AddParent(Person person)
        {
            parents.Add(person);
        }

        public override string ToString()
        {
            return $"{name} {birthday}";
        }
    }
}