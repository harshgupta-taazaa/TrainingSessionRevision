using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentApi.Model
{
    public class AddressModel
    {
        public string StaffAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string PinCode { get; set; }
    }
}
