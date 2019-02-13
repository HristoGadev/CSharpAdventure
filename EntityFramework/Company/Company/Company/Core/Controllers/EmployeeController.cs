using AutoMapper;
using AutoMapper.QueryableExtensions;
using CompanyApp.Core.Contracts;
using CompanyApp.Core.Dtos;
using CompanyData;
using CompanyModel;
using System;
using System.Linq;

namespace CompanyApp.Core.Controllers
{
    public class EmployeeController : IEmployeeController
    {
        private readonly CompanyContext context;
        private readonly IMapper mapper;
        public EmployeeController(CompanyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employee>(employeeDto);
            this.context.Employees.Add(employee);
            this.context.SaveChanges();
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }
            employee.Address = address;
            this.context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }
            employee.BirthDate = date;
            this.context.SaveChanges();
        }

        public EmployeeDto EmployeeInfo(int employeeId)
        {
            var employee = context
                .Employees
                .Where(x=>x.EmployeeId==employeeId)
                .ProjectTo<EmployeeDto>()
                .SingleOrDefault();

            var employeeDto = mapper.Map<EmployeeDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }
            return employeeDto;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfoDto(int employeeId)
        {
            var employee = context
                .Employees
                .Where(x => x.EmployeeId == employeeId)
                .ProjectTo<EmployeeDto>()
                .SingleOrDefault();

            var employeeDto = mapper.Map<EmployeePersonalInfoDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }
            return employeeDto;
        }
    }
}
