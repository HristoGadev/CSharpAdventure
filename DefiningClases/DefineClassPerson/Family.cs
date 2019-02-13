using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        private List<Person> members;

        public Family()
        {
            this.Members = new List<Person>();
        }
        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }
        public void AddMembers(Person member)
        {
            Members.Add(member);
        }
        public void GetOldestMember()
        {
            foreach (var member in Members.OrderBy(x => x.Name).Where(a => a.Age > 30))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
