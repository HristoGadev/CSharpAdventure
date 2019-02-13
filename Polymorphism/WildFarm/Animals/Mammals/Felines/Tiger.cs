using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private static double weightIncreased = 1.00;
    
        public Tiger(string name, double weight, string livingRegion,string breed)
            : base(name, weight, livingRegion,breed)
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
                throw new ArgumentException($"Tiger does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
