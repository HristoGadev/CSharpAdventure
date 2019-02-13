using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string type;
        private string bakingTechnique;
        private double weight;

        public Dough(string type, string bakingTechnique, double weight)
        {
            Type = type;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string Type
        {
            get => type;

            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    Exception ex = new Exception("Invalid type of dough.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                type = value;
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    Exception ex = new Exception("Invalid type of dough.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                bakingTechnique = value;
            }
        }
        public double Weight
        {
            get => weight;

            set
            {
                if (value < 1 || value > 200)
                {
                    Exception ex = new Exception("Dough weight should be in the range [1..200].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }

        public double TakeTypeModifiers()
        {
            if (this.type.ToLower() == "white")
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
        }
        public double TakeBakingTechniqueModifiers()
        {
            if (this.bakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.bakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }
            else
            {
                return 1;
            }
        }
        public double DoughCalories()
        {
            var totalDoughCalories= (2 * this.weight) * TakeBakingTechniqueModifiers() * TakeTypeModifiers();
            return totalDoughCalories;
        }

    }
}
