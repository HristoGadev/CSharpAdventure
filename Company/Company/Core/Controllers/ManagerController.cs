using AutoMapper;
using CompanyApp.Core.Contracts;
using CompanyApp.Core.Dtos;
using CompanyData;
using System;
using  System.Linq;
using AutoMapper.QueryableExtensions;

namespace CompanyApp.Core.Controllers
{
    public class ManagerController : IManagerController
    {
        private readonly CompanyContext context;
        private readonly IMapper mapper;

        public ManagerController(CompanyContext companyContext,IMapper mapper)
        {
            this.context = companyContext;
            this.mapper = mapper;
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            var employee = context
                .Employees
                .Where(x => x.EmployeeId == employeeId)
                .ProjectTo<ManagerDto>()
                .SingleOrDefault();

            var employeeDto = mapper.Map<ManagerDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }
            return employeeDto;
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = context.Employees.Find(employeeId);
            var manager = context.Employees.Find(managerId);

            if (employee == null || manager == null)
            {
                throw new ArgumentException("Not valid Id");
            }

            employee.Manager = manager;

            context.SaveChanges();
           

        }
    }
}
