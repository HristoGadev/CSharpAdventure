using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        private static double weightIncreased = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
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
                throw new ArgumentException($"Dog does not eat {food.GetType().Name}!");
            }
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
        public override string ToString()
        {
            return base.ToString()+$"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
