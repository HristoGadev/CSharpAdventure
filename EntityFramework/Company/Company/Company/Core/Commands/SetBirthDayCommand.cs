using CompanyApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{
    public class SetBirthDayCommand : ICommand
    {
        private readonly IEmployeeController controller;
        public SetBirthDayCommand(IEmployeeController employeeController)
        {
            this.controller = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            DateTime date = DateTime.ParseExact(args[1], "dd-MM-yyyy", null);
            this.controller.SetBirthday(id, date);

            return "Commands accomplished successfully!";
        }
    }
}
