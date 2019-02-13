using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            
            for (int i = 0; i < lenght; i++)
            {
                list.Add(Console.ReadLine());
            }

            foreach (var item in list.Distinct())
            {
                Console.WriteLine(item);
            }
        }
    }
}
