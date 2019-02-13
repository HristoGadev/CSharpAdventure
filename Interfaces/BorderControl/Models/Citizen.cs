using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthday;
        private int food;

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }
        public int Age
        {
            get => age;
            private set => age = value;
        }
        public string Id
        {
            get => id;
            private set => id = value;
        }
        public string Birthday
        {
            get => birthday;
            private set => birthday = value;
        }
        public int Food
        {
            get => food;
            private set => food = value;
        }

        public int BuyFood()
        {
           return this.Food = 10;
        }
    }
}
