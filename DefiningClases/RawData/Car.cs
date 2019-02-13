using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car()
        {
            Tires = new List<Tire>(4);
        }

        public override string ToString()
        {
            return Model;
        }
    }
}