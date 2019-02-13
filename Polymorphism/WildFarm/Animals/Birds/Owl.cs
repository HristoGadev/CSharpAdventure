using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        private static double weightIncreased = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.Weight += food.Quantity * weightIncreased;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Owl does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
