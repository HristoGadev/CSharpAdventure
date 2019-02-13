using System;

namespace ShoppingCenter
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
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

        public double Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    MoneyExseption();
                    
                }
                cost = value;
            }
        }

        private void MoneyExseption()
        {
            Exception ex = new ArgumentException("Money cannot be negative");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }

        private void NameExseption()
        {
            Exception ex = new ArgumentException("Name cannot be empty");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
