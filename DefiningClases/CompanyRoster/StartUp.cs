using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());

            var company = new Dictionary<string, List<Employee>>();

            for (int count = 0; count < employeesCount; count++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                Employee employee = new Employee();

                employee.Name = employeeInfo[0];
                employee.Salary = decimal.Parse(employeeInfo[1]);
                employee.Position = employeeInfo[2];
                employee.Department = employeeInfo[3];

                switch (employeeInfo.Length)
                {
                    case 5:
                        try
                        {
                            employee.Age = int.Parse(employeeInfo[4]);
                        }
                        catch (Exception)
                        {
                            employee.Email = employeeInfo[4];
                        }
                        break;
                    case 6:
                        employee.Email = employeeInfo[4];
                        employee.Age = int.Parse(employeeInfo[5]);
                        break;
                }

                if (company.ContainsKey(employee.Department) == false)
                {
                    company.Add(employee.Department, new List<Employee>());
                }

                company[employee.Department].Add(employee);
            }

            decimal maxAverageSalary = company.Values.Max(s => s.Average(e => e.Salary));

            foreach (var department in company.Where(s => s.Value.Average(e => e.Salary) == maxAverageSalary))
            {
                Console.WriteLine($"Highest Average Salary: {department.Key}");
                Console.WriteLine(string.Join(Environment.NewLine, department.Value.OrderByDescending(e => e.Salary)));
            }
        }
    }
}