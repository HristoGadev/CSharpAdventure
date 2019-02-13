using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            var engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            for (int counter = 0; counter < enginesCount; counter++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine()
                {
                    Model = engineInfo[0],
                    Power = engineInfo[1]
                };

                switch (engineInfo.Length)
                {
                    case 3:
                        try
                        {
                            engine.Displacement = int.Parse(engineInfo[2]).ToString();
                        }
                        catch (Exception)
                        {
                            engine.Efficiency = engineInfo[2];
                        }
                        break;
                    case 4:
                        engine.Displacement = engineInfo[2];
                        engine.Efficiency = engineInfo[3];
                        break;
                }

                engines.Add(engine.Model, engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < carsCount; counter++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car()
                {
                    Model = carInfo[0],
                    Engine = engines[carInfo[1]]
                };

                switch (carInfo.Length)
                {
                    case 3:
                        try
                        {
                            car.Weight = int.Parse(carInfo[2]).ToString();
                        }
                        catch (Exception)
                        {
                            car.Color = carInfo[2];
                        }
                        break;
                    case 4:
                        car.Weight = carInfo[2];
                        car.Color = carInfo[3];
                        break;
                }

                cars.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}