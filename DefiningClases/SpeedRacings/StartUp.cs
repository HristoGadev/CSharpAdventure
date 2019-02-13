using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int count = 0; count < carsCount; count++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car car = new Car
                {
                    Model = carInfo[0],
                    FuelAmount = double.Parse(carInfo[1]),
                    FuelConsuption = double.Parse(carInfo[2])
                };

                if (cars.ContainsKey(car.Model) == false)
                {
                    cars.Add(car.Model, car);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                string model = commandArgs[1];
                double distance = double.Parse(commandArgs[2]);

                cars[model].Drive(distance);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars.Values));
        }
    }
}