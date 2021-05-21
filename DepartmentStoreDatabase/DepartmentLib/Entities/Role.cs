using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string StaffRole { get; set; }
        public string RoleDescription { get; set; }
        public List<Staff> staff { get; set; }
    }
}
