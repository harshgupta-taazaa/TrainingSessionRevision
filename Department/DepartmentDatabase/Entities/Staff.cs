using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNo {get; set;}
        public char Gender {get; set;}
        public string Salary {get; set;}
        public int RoleId {get; set;}
        public Role Role {get;set;}

    }
}
