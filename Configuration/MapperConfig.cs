using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            //1 It say we can convert Leavetype to vm   & also reverse true
            //It will map if it has same DataType & VaraiableName
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            //2 We have to registered in Services.

            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
        }
    }
}
