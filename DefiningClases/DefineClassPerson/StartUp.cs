﻿using DefiningClasses;
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Family members = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);

                Person person = new Person(name, age);
               
                members.AddMembers(person);
            }
            members.GetOldestMember();
           
        }

       
    }
}
