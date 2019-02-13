using CompanyApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{

    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeController controller;
        public EmployeePersonalInfoCommand(IEmployeeController employeeController)
        {
            this.controller = employeeController;
        }
        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);

            var employeeDto = controller.GetEmployeePersonalInfoDto(id);

            return $"{employeeDto.FirstName} {employeeDto.LastName}" +
                $"BirthDate: {employeeDto.BirthDate.Value.ToString("dd-MM-yyyy")}" +
                $"Address: {employeeDto.Address}";
        }
    }
}
