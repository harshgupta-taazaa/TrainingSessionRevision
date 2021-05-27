using AutoMapper;
using DepartmentApi.Model;
using DepartmentDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentApi
{
    public class StaffProfile:Profile
    {
        public StaffProfile()
        {
            this.CreateMap<Staff, StaffModel>().ReverseMap();
            this.CreateMap<Role, RoleModel>().ReverseMap();

            this.CreateMap<Product, ProductModel>().ReverseMap();
        }
    }
}
