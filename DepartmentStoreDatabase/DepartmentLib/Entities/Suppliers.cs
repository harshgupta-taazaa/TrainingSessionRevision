using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }

        public int ProductOrderId { get; set; }
        public ProductOrder productOrder { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; }
    }
}
