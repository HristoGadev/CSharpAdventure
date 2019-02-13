using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals.Birds.Factory;
using WildFarm.Animals.Mammals.Factory;
using WildFarm.Animals.Mammals.Felines.Factory;
using WildFarm.Contracts;
using WildFarm.Foods.Factory;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        private BirdFactory birdFactory;
        private FelinesFactory felinesFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private List<Animal> animals;
        private Animal animal;

        public Engine()
        {
            this.birdFactory = new BirdFactory();
            this.felinesFactory = new FelinesFactory();
            this.mammalFactory = new MammalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    var animalArgs = input.Split();
                    var foodInfo = Console.ReadLine().Split();
                    var animalType = animalArgs[0];
                    var name = animalArgs[1];
                    var weight = double.Parse(animalArgs[2]);

                    if (animalType == "Hen" || animalType == "Owl")
                    {
                        var wingSize = double.Parse(animalArgs[3]);
                        animal = birdFactory.CreateBird(animalType, name, weight, wingSize);
                    }
                    else if (animalType == "Cat" || animalType == "Tiger")
                    {
                        var region = animalArgs[3];
                        var breed = animalArgs[4];
                        animal = felinesFactory.CreateFeline(animalType, name, weight, region, breed);
                    }
                    if (animalType == "Dog" || animalType == "Mouse")
                    {
                        var region = animalArgs[3];
                        animal = mammalFactory.CreateMammal(animalType, name, weight, region);
                    }
                    var foodType = foodInfo[0];
                    var foodQuantity = int.Parse(foodInfo[1]);

                    var food = foodFactory.CreateFood(foodType, foodQuantity);
                    animal.ProduceSound();
                    animal.Eat(food);
                    animals.Add(animal);
                    Console.WriteLine(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
