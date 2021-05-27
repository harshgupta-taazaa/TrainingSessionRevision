using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class ProductSupplier
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public Product product { get; set; }
        public Suppliers suppliers { get; set; }
    }
}
