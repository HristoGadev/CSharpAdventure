using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private static double weightIncreased = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType().Name;
            if (food is Vegetable || food is Fruit)
            {
                this.Weight += food.Quantity * weightIncreased;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Mouse does not eat {food.GetType().Name}!");
            }
           
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
