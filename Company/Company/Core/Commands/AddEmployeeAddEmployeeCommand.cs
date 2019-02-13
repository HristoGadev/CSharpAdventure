using CompanyApp.Core.Contracts;
using CompanyApp.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly IEmployeeController controller;
        public AddEmployeeCommand(IEmployeeController employeeController)
        {
            this.controller = employeeController;
        }

        public string Execute(string[] args)
        {
            string firstName = args[0];
            string secondName = args[1];
            decimal salary = decimal.Parse(args[2]);

            EmployeeDto employee = new EmployeeDto
            {
                FirstName = firstName,
                LastName = secondName,
                Salary = salary
            };
            this.controller.AddEmployee(employee);

            return $"Employee {firstName} {secondName} added successesfully ";
        }
    }
}
