using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; }
    }
}
