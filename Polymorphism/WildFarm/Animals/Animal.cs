using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Foods;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
           
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Weight
        {
            get => weight;
            set => weight = value;
        }
        public int FoodEaten
        {
            get => foodEaten;
            set => foodEaten = value;
        }

        public abstract void ProduceSound();
        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
