using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.Entities
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductAmount { get; set; }
        public string DeliveryDate { get; set; }
        public List<Suppliers> Supplier { get; set; }
    }
}
