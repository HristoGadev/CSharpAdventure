using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    Exception ex = new Exception($"Cannot place {value} on top of your pizza.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                type = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    Exception ex = new Exception($"{this.Type} weight should be in the range [1..50].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }
        public double ToppingTypeModifiers()
        {
            if (this.type.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (this.type.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (this.type.ToLower() == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }
        public double ToppingCalories()
        {
            var totalToppingCalories= (2 * this.weight) * ToppingTypeModifiers();
            return totalToppingCalories;
        }
    }
}
