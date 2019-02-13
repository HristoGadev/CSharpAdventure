using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var pizzaInfo = Console.ReadLine().Split();
            var pizzaName = pizzaInfo[1];

            Pizza pizza = new Pizza(pizzaName);

            var doughInfo = Console.ReadLine().Split();
            FillDoughIngridients(doughInfo, pizza);

            var input = Console.ReadLine();
            var counter = 0;
            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ingridient = tokens[0];

                if (counter > 10)
                {
                    Exception ex = new Exception("Number of toppings should be in range [0..10].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                FillToppingIngridients(tokens, pizza);
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine(pizza.ToString());


        }

        private static void FillToppingIngridients(string[] tokens, Pizza pizza)
        {
            var type = tokens[1];
            var weight = double.Parse(tokens[2]);
            Topping topping = new Topping(type, weight);
            pizza.AddTopping(topping);
        }

        private static void FillDoughIngridients(string[] doughInfo, Pizza pizza)
        {
            var type = doughInfo[1];
            var bakingTechnique = doughInfo[2];
            var weight = double.Parse(doughInfo[3]);

            Dough dough = new Dough(type, bakingTechnique, weight);
            pizza.Dough = dough;
        }
    }
}
