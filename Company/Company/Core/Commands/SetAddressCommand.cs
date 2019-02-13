using CompanyApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly IEmployeeController controller;
        public SetAddressCommand(IEmployeeController employeeController)
        {
            this.controller = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            string address = args[1];

            this.controller.SetAddress(id, address);

            return "Commands accomplished successfully!";
        }
    }
}
