using System;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public Engine()
        {
            displacement = "n/a";
            efficiency = "n/a";
        }

        public override string ToString()
        {
            return $"{model}:{Environment.NewLine}    Power: {power}{Environment.NewLine}    Displacement: {displacement}{Environment.NewLine}    Efficiency: {efficiency}";
        }
    }
}