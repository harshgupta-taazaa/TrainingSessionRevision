using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductAmount { get; set; }

        public String DeliveryDate { get; set; }

        public List<Suppliers> Supplier { get; set; }
    }
}
