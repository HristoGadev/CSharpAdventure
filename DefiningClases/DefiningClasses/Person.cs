﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
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
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
      
    }
}
