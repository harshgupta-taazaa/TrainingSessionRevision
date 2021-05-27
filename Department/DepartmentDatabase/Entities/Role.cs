using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string StaffRole { get; set; }
        public string RoleDescription { get; set; }
        public List<Staff> Staff { get; set; }
    }

}
