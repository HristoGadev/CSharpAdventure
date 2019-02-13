using System.Text;
using CompanyApp.Core.Contracts;

namespace CompanyApp.Core.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly IManagerController controller;
        public ManagerInfoCommand(IManagerController controller)
        {
            this.controller = controller;
        }
        public string Execute(string[] args)
        {
            StringBuilder sb=new StringBuilder();

            int employeeId = int.Parse(args[0]);

            var managerDto = controller.GetManagerInfo(employeeId);

            sb.AppendLine($"{managerDto.FirstName} {managerDto.LastName} has {managerDto.EmployeesCount} Employees");

            foreach (var employee in managerDto.EmployeesDto)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} with {employee.Salary} Salary");
            }

            return sb.ToString().Trim();
        }
    }
}
 