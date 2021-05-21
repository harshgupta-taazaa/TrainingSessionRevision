using DepartmentLib.Databasecontext;
using DepartmentLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentUI.Controllers
{ 

    public class DepartmentQuerries
    {
        DepartmentContext _context = new DepartmentContext();

        public void QuerriesOnStaffTable()
        {
             var staffdata = _context.Staff.Where(s=>s.FirstName.ToLower()=="jay").ToList();
            //var staffdata = _context.Staff.Where(s => s.PhoneNo == "9876546754");


            //var a = _context.Staff.Find(6);
            //_context.Staff.Remove(a);
            //_context.SaveChanges();


            //var staffdata = _context.Staff.Where(s =>EF.Functions.Like( s.FirstName ,"%a%")).OrderBy(s=>s.FirstName).ToList();
            //var b = _context.Staff.Find(1);
            //Console.WriteLine(b.FirstName);
            //var staffdata = _context.Staff.Skip(1).Take(1);

            var staff = from Staff in _context.Set<Staff>()
                        join Address in _context.Set<Address>() on Staff.Id equals Address.StaffId
                        where Address.State.ToLower() == "up"
                        select new { Staff, Address };


            var data = _context.Staff;
            foreach(var a in staff)
            {
                Console.WriteLine($"{a.Staff.FirstName}, {a.Address.StaffAddress}");
            }
        }
        public void QueriesPerformedforProductTables()
        {
            // var a = _context.Product.Where(s => s.Category.Id == 2).ToList();

            //Querry product based on product Name
            var product = _context.Product.Where(s => s.ProductName == "pen").ToList();


            //Querry product Based on Category
            var productNameBasedOnCategory = _context.Product.Where(s => s.Category.CategoryName.ToLower() == "fruit").ToList();

            //Query -- No of products OutofStock
            var productInstock = from Product in _context.Set<Product>()
                           join Inventory in _context.Set<Inventory>() on Product.Id equals Inventory.productId
                           where Inventory.IsInStock==true
                           select new { Product };
            //Query -- No of products OutofStock

            var ProductOutOfstock = from Product in _context.Set<Product>()
                          join Inventory in _context.Set<Inventory>() on Product.Id equals Inventory.productId
                          where Inventory.IsInStock == false
                          select new { Product };
            //var ProductCategoryinDesc = from Product in _context.Set<Product>()
            //                            join Category in _context.Set<Category>() on Product.CategoryId equals Category.Id
            //                            join Inventory in _context.Set<Inventory>() on Product.Id equals Inventory.productId
            //                            group  Inventory by Inventory.Quantity into g 
            //                            orderby g.Key descending
            //                            select new { Product };



            //Querry Product
            //foreach (var b in ProductCategoryinDesc)
            //{
            //    Console.WriteLine(b.Product.ProductName);
            //}
        }

        public void QuerriesRelatedProductandSupplier()
        {
            var data = from Product in _context.Set<Product>()
                       join ProductSupplier in _context.Set<ProductSupplier>() on Product.Id equals ProductSupplier.ProductId
                       join Suppliers in _context.Set<Suppliers>() on ProductSupplier.SupplierId equals Suppliers.Id
                       join ProductOrder in _context.Set<ProductOrder>() on Suppliers.ProductOrderId equals ProductOrder.Id
                       where ProductOrder.ProductName=="pen"
                       select new { Product, Suppliers , ProductOrder};

            foreach(var a in data)
            {
                Console.WriteLine($"{a.Product.ProductName} {a.Suppliers.SupplierName} {a.ProductOrder.ProductName} ");
            }
        }
    }
}
