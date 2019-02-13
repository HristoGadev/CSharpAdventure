using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCenter
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            FillPersons(persons);

            FillProducts(products);

            FindPersonsProducts(persons,products);

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }

        }

        private static void FindPersonsProducts( List<Person> persons, List<Product> products)
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var commands = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = commands[0];
                var productName = commands[1];

                var product = products.First(x => x.Name == productName);
                persons.First(x => x.Name == person).AddProduct(product);
                input = Console.ReadLine();
            }
        }

        private static void FillProducts(List<Product> products)
        {
            var productsInfo = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < productsInfo.Length; i += 2)
            {
                var nameProduct = productsInfo[i];
                var price = double.Parse(productsInfo[i + 1]);
                Product product = new Product(nameProduct, price);
                products.Add(product);
            }
        }

        private static void FillPersons(List<Person> persons)
        {
            var people = Console.ReadLine()
               .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            for (int i = 0; i < people.Length; i += 2)
            {
                var name = people[i];
                var money = int.Parse(people[i + 1]);
                Person person = new Person(name, money);
                persons.Add(person);

            }
        }
    }
}
