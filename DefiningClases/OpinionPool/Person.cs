using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        private List<Person> members;

        public Person()
        {

        }
        public Person(int age)
           : this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
            this.Members = new List<Person>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void AddMembers(Person member)
        {
            if (members == null)
            {
                throw new Exception();
            }
            Members.Add(member);
        }
        public void GetMemberOver()
        {
            foreach (var member in Members.OrderBy(n => n.Name).Where(a => a.Age > 30))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
