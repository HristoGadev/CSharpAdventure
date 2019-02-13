using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        private const string model = "488-Spider";

        public Ferrari(string driver)
        {
            Driver = driver;
        }

        public string Driver { get; private set; }

        public string Model { get; private set; }

        public string Brakes()
        {
           return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{model}/{Brakes()}/{Gas()}/{this.Driver}";
        }
    }
}
