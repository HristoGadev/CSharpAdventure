using System;

namespace ClassBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);

        }
    }
}
