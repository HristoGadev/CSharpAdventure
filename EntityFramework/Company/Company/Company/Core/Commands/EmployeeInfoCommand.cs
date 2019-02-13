using CompanyApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{
    public class EmployeeInfoCommand : ICommand
    {
        private readonly IEmployeeController controller;
        public EmployeeInfoCommand(IEmployeeController employeeController)
        {
            this.controller = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);

            var employeeDto = controller.EmployeeInfo(id);

            return $"ID: {employeeDto.Id} -  {employeeDto.FirstName} {employeeDto.LastName} Salary {employeeDto.Salary}";
        }
    }
}
