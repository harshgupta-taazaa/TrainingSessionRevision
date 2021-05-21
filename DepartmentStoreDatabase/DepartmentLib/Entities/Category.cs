using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentLib.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Categorydescription { get; set; }


        public List<Product> product { get; set; }
    }
}
