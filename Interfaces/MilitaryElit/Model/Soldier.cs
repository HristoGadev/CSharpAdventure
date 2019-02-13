using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public abstract class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private int id;

        public Soldier(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName
        {
            get => firstName;
            private set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            private set => lastName = value;
        }
        public int Id
        {
            get => id;
            private set => id = value;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} ";
        }
    }
}
