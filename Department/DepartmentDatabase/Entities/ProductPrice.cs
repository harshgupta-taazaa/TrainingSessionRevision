using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class ProductPrice
    {

        public int Id { get; set; }
        public float ProductCostPrice { get; set; }
        public float ProductSellingPrice { get; set; }
        public int productId { get; set; }

        public Product product { get; set; }
    }
}
