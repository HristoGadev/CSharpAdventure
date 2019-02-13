using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Models;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        private static double weightIncreased = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.Weight += food.Quantity * weightIncreased;
            this.FoodEaten += food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
