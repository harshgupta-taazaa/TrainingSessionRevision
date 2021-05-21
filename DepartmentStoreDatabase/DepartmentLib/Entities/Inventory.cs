using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public bool IsInStock { get; set; }
        public int Quantity { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
