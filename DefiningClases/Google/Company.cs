using System;

namespace DefiningClasses
{
    public class Company
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Company(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Environment.NewLine}{Name} {Department} {Salary:F2}";
        }
    }
}