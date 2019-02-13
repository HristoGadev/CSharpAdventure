using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int count = 0; count < carsCount; count++)
            {
                string[] carInfo = Console.ReadLine().Split();

                Engine engine = new Engine
                {
                    Speed = int.Parse(carInfo[1]),
                    Power = int.Parse(carInfo[2])
                };
                Cargo cargo = new Cargo
                {
                    Weigth = int.Parse(carInfo[3]),
                    Type = carInfo[4]
                };
                List<Tire> tires = new List<Tire>
            {
                new Tire{ Pressure = double.Parse(carInfo[5]), Age = int.Parse(carInfo[6])},
                new Tire{ Pressure = double.Parse(carInfo[7]), Age = int.Parse(carInfo[8])},
                new Tire{ Pressure = double.Parse(carInfo[9]), Age = int.Parse(carInfo[10])},
                new Tire{ Pressure = double.Parse(carInfo[11]), Age = int.Parse(carInfo[12])}
            };
                Car car = new Car
                {
                    Model = carInfo[0],
                    Engine = engine,
                    Cargo = cargo,
                    Tires = tires
                };

                if (cars.ContainsKey(car.Model) == false)
                {
                    cars.Add(car.Model, car);
                }
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    Console.WriteLine(string.Join(Environment.NewLine, cars.Values.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))));
                    break;
                case "flamable":
                    Console.WriteLine(string.Join(Environment.NewLine, cars.Values.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)));
                    break;
            }
        }
    }
}