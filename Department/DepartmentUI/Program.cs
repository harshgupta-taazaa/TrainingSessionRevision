using DepartmentDatabase.DatabaseContext;
using DepartmentDatabase.Entities;
using System;
using System.Linq;

namespace DepartmentUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentContext _context = new DepartmentContext();
            //_context.Role.Add(new Role { StaffRole="manages counter", RoleDescription ="manages all the product billings"});

            //_context.Role.Add(new Role { StaffRole = "manages inventory", RoleDescription = "manage all the product in stock" });

            //_context.Staff.Add(new Staff { FirstName = "jay", LastName = "singh", Gender = 'M', PhoneNo = "9876567286", Salary = "23000", RoleId = 2 });
            //_context.Staff.Add(new Staff { FirstName = "rahul", LastName = "pal", Gender = 'M', PhoneNo = "9876455286", Salary = "13000", RoleId = 1 });
            //_context.Staff.Add(new Staff { FirstName = "Maya", LastName = "soni", Gender = 'F', PhoneNo = "7487656286", Salary = "25000", RoleId = 2 });
            // _context.Staff.Add(new Staff { FirstName = "ravi", LastName = "kumar", Gender = 'M', PhoneNo = "9999767286", Salary = "8000",Role=new Role { StaffRole="Swipper",RoleDescription="Clean the Department"} });

            //_context.Category.Add(new Category { CategoryName = "fruit", Categorydescription = "used for eating" });
            //_context.Category.Add(new Category { CategoryName = "stationary", Categorydescription = "used for studying" });

            //_context.Product.Add(new Product { ProductName = "apple", ProductBrand = "xyz", CategoryId = 2 });
            //_context.Product.Add(new Product { ProductName = "pen", ProductBrand = "cello", CategoryId = 1 });
            //_context.Product.Add(new Product { ProductName = "orange", ProductBrand = "abc", CategoryId = 2 });


            //_context.Inventory.Add(new Inventory { IsInStock = true, Quantity = 10, productId = 1 });
            //_context.Inventory.Add(new Inventory { IsInStock = false, Quantity = 0, productId = 2 });
            //_context.Inventory.Add(new Inventory { IsInStock = true, Quantity = 23, productId = 3 });


            //_context.ProductPrice.Add(new ProductPrice { ProductCostPrice = 100, ProductSellingPrice = 120, productId = 3 });
            //_context.ProductPrice.Add(new ProductPrice { ProductCostPrice = 20, ProductSellingPrice = 25, productId = 2 });
            //_context.ProductPrice.Add(new ProductPrice { ProductCostPrice = 150, ProductSellingPrice = 200, productId = 1 });

            //_context.Address.Add(new Address { StaffAddress = "12/3 balak pur ", State = "Up", City = "Faizabad", PinCode = "224001", StaffId = 5 });
            //_context.Address.Add(new Address { StaffAddress = "335 rekabganj  ", State = "Up", City = "Ayodhya", PinCode = "224002", StaffId = 6 });
            //_context.Address.Add(new Address { StaffAddress = "green city bbd ", State = "Up", City = "Lucknow", PinCode = "224222", StaffId = 7 });
            //_context.SaveChanges();

            var querry1 =  from Staff in _context.Set<Staff>()
                           join Role in _context.Set<Role>() on Staff.RoleId equals Role.Id
                           join Address in _context.Set<Address>() on Staff.Id equals Address.StaffId
                           select new { Staff, Address, Role };
            foreach (var a in querry1)
            {
                Console.WriteLine($"{a.Staff.FirstName}, {a.Address.StaffAddress} ,{a.Role.StaffRole}");
            }
        }
    }
}
