using CompanyApp.Core.Dtos;
using System;

namespace CompanyApp.Core.Contracts
{
    public interface IEmployeeController
    {
        void AddEmployee(EmployeeDto employeeDto);

        void SetBirthday(int employeeId, DateTime date);
        void SetAddress(int employeeId, string address);

        EmployeeDto EmployeeInfo(int employeeId);
        EmployeePersonalInfoDto GetEmployeePersonalInfoDto(int employeeId);

    }
}
