using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Salary { get; set; }
        public string PhoneNo { get; set; }
        
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
