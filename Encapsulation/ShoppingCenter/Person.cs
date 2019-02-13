using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCenter
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
                {
                    NameExseption();

                }
                name = value;
            }
        }


        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    MoneyExseption();

                }
                money = value;
            }
        }

        public List<Product> Bag
        {
            get { return bag; }
            set { bag = value; }
        }

        private void NameExseption()
        {
            Exception ex = new ArgumentException("Name cannot be empty");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
        private void MoneyExseption()
        {
            Exception ex= new ArgumentException("Money cannot be negative");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
        public void AddProduct(Product product)
        {
            var cost = product.Cost;
            if (this.money < cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                return;
            }
            this.Bag.Add(product);
            this.Money -= cost;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }
        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                return $"{this.Name} - {string.Join(", ", bag.Select(x => x.ToString()))}";
            }
        }
    }
}
