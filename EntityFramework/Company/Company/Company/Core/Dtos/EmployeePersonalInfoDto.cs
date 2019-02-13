using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core.Dtos
{
    public class EmployeePersonalInfoDto
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
    }
}
