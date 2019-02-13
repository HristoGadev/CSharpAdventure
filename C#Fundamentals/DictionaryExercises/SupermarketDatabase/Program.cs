using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, double>> products
                = new Dictionary<string, Dictionary<double, double>>();



            while (true)
            {
                var line = Console.ReadLine();
                var input = line
                    .Split()
                    .ToArray();

                if (line == "stocked")
                    break;

                var name = input[0];
                var quantity = double.Parse(input[2]);
                var price = double.Parse(input[1]);

                if (products.ContainsKey(name) == false)
                {
                    products.Add(name, new Dictionary<double, double>());
                }
                if (products[name].ContainsKey(price) == false)
                {
                    products[name].Add(price, 0);
                }
                products[name][price] += quantity;

            }
            double grandTotal = 0;
            foreach (var product in products)
            {
                var name = product.Key;
                var lastPrice = product.Value.Keys.Last();
                var quantities = product.Value.Values.Sum();
                var total = lastPrice * quantities;
                grandTotal += total;
                Console.WriteLine($"{name}: ${lastPrice:f2} * {quantities} = ${total:f2}");
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");

        }
    }
}
