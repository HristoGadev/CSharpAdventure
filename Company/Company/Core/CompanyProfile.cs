using AutoMapper;
using CompanyApp.Core.Dtos;
using CompanyModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Core
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, ManagerDto>()
                .ForMember(dest=>dest.EmployeesDto, from=>from.MapFrom(x=>x.ManagerEmployees))
                .ReverseMap();
            CreateMap<Employee, EmployeePersonalInfoDto>().ReverseMap();
        }
    }
}
