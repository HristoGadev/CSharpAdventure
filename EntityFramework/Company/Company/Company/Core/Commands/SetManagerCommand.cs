using CompanyApp.Core.Contracts;
using CompanyApp.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{
    public class SetManagerCommand : ICommand
    {
        private readonly IManagerController controller;
        public SetManagerCommand(IManagerController managerController)
        {
            this.controller = managerController;
        }
        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            int managerId = int.Parse(args[1]);

            this.controller.SetManager(employeeId, managerId);

            return $"Manager is successfully set";
        }
    }
}
