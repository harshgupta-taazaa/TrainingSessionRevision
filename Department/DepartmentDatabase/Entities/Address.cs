using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string StaffAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string PinCode { get;set; }
        public int StaffId { get; set; }
        public Staff staff { get; set; }
    }
}
