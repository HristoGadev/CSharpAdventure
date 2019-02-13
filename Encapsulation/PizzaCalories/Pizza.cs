using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
            Dough = dough;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    Exception ex = new Exception("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        internal Dough Dough { get => dough; set => dough = value; }
        internal List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (value.Count < 0 || value.Count > 10)
                {
                    Exception ex = new Exception("Number of toppings should be in range [0..10]");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                toppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
           this.Toppings.Add(topping);
        }
        public double TotalPizzaCalories()
        {
            var totalTopingCalories = Toppings.Sum(x => x.ToppingCalories());
            var totalPizzaCalories = totalTopingCalories + this.Dough.DoughCalories();
            return totalPizzaCalories;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.TotalPizzaCalories():f2} Calories.";
        }
    }
}
