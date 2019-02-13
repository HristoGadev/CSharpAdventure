using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private static double weightIncreased = 0.30;
       

        public Cat(string name, double weight, string livingRegion,string breed) 
            : base(name, weight, livingRegion,breed)
        {
           
        }
        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.Weight += food.Quantity * weightIncreased;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Cat does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return base.ToString()+$"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
