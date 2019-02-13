﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm.Animals.Mammals.Factory
{
    public class MammalFactory
    {
        public Mammal CreateMammal(string type, string name, double weight, string livingRegion)
        {
            type = type.ToLower();

            switch (type)
            {
                case "dog":
                    return new Dog(name, weight, livingRegion);
                case "mouse":
                    return new Mouse(name, weight, livingRegion);
                default:
                    throw new ArgumentException("Invalid type mammal!");
            }
        }
    }
}
