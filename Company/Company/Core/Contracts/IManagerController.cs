using CompanyApp.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Contracts
{
    public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);
        ManagerDto GetManagerInfo(int employeeId);


    }
}
