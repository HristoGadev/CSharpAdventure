using System;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
            weight = "n/a";
            color = "n/a";
        }

        public override string ToString()
        {
            return $"{model}:{Environment.NewLine}  {engine}{Environment.NewLine}  Weight: {weight}{Environment.NewLine}  Color: {color}";
        }
    }
}