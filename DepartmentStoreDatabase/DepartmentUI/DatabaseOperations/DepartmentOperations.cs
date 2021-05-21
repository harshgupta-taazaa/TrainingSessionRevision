using DepartmentLib.Databasecontext;
using DepartmentLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentUI.DatabaseOperations
{
    public class DepartmentOperations
    {
        public DepartmentContext _context = new DepartmentContext();
        public void AddingDataToStaffTable()
        {
            
            _context.Staff.Add(new Staff { FirstName = "jay", LastName="singh",Gender='M',PhoneNo="9876567286",Salary=23000,RoleId=2});
            _context.Staff.Add(new Staff { FirstName = "rahul", LastName = "pal", Gender = 'M', PhoneNo = "9876455286", Salary = 13000, RoleId = 1 });
           // _context.Staff.Add(new Staff { FirstName = "Maya", LastName = "soni", Gender = 'F', PhoneNo = "7487656286", Salary = 25000, RoleId = 2 });
            _context.Staff.Add(new Staff { FirstName = "lucky", LastName = "yadav", Gender = 'M', PhoneNo = "8777767286", Salary = 20000, RoleId=3 });
            _context.SaveChanges();
        }
        public void AddingDataToRoles()
        {
            _context.Role.Add(new Role { StaffRole = "manager", RoleDescription = "manages the whole department" });
            _context.Role.Add(new Role { StaffRole = "Manage Counter", RoleDescription = "manages the counter and bills" });
            _context.Role.Add(new Role { StaffRole = "Manage Inventory", RoleDescription = "manages whole inventory of stocks" });

            _context.SaveChanges();
        }
        public void AddingDataToStaffAddress()
        {
            _context.Address.Add(new Address { StaffAddress="12/3 balak pur ", State="Up",City="Faizabad",PinCode="224001",StaffId=10});
            _context.Address.Add(new Address { StaffAddress = "335 rekabganj  ", State = "Up", City = "Ayodhya", PinCode = "224002", StaffId = 11 });
            _context.Address.Add(new Address { StaffAddress = "green city bbd ", State = "Up", City = "Lucknow", PinCode = "224222", StaffId = 12 });
            _context.SaveChanges();
        }

        public void AddingDataToCategory()
        {
            _context.Category.Add(new Category { CategoryName="fruit", Categorydescription="used for eating"});
            _context.SaveChanges();
        }
        public void AddingDataToInventory()
        {
            //var product = _context.Product.Find(1);
            _context.Inventory.Add(new Inventory { IsInStock = true, Quantity = 10, productId = 1 });
            _context.Inventory.Add(new Inventory { IsInStock = false, Quantity = 0, productId = 2 });
            _context.Inventory.Add(new Inventory { IsInStock = true, Quantity = 23, productId = 3 });
            _context.SaveChanges();
        }
        public void AddingDataToProduct()
        {
            _context.Product.Add(new Product { ProductName = "apple", ProductBrand = "xyz", CategoryId = 2 });
            _context.Product.Add(new Product { ProductName = "pen", ProductBrand = "cello", CategoryId = 1 });
            _context.Product.Add(new Product { ProductName = "orange", ProductBrand = "abc", CategoryId = 2 });
            _context.SaveChanges();
        }

        public void AddingDataToProductPrice()
        {
            _context.ProductPrice.Add(new ProductPrice {ProductCostPrice=100,ProductSellingPrice=120,productId=3 });
            _context.ProductPrice.Add(new ProductPrice { ProductCostPrice = 20, ProductSellingPrice = 25, productId = 2 });
            _context.ProductPrice.Add(new ProductPrice { ProductCostPrice = 150, ProductSellingPrice = 200, productId = 1 });
            _context.SaveChanges();
        }
        public void AddingDataToSuppliers()
        {
            _context.Supplier.Add(new Suppliers { SupplierName = "raj", PhoneNo = "6578678900", EmailAddress = "raj@gmail.com", ProductOrderId = 1 });
            _context.Supplier.Add(new Suppliers { SupplierName = "suraj", PhoneNo = "9876543210", EmailAddress = "suraj@gmail.com", ProductOrderId = 2 });
            _context.Supplier.Add(new Suppliers { SupplierName = "pankaj", PhoneNo = "9878787654", EmailAddress = "pankaj@gmail.com", ProductOrderId = 4 });
            _context.Supplier.Add(new Suppliers { SupplierName = "ravi", PhoneNo = "7869567786", EmailAddress = "ravi@gmail.com", ProductOrderId = 2 });
            _context.Supplier.Add(new Suppliers { SupplierName = "bunty", PhoneNo = "6785674320", EmailAddress = "bunty@gmail.com", ProductOrderId = 3 });
            _context.Supplier.Add(new Suppliers { SupplierName = "siddharth", PhoneNo = "6785678906", EmailAddress = "siddharth@gmail.com", ProductOrderId = 5 });
            _context.SaveChanges();
        }

        public void AddingDataToProductOrder()
        {
            _context.ProductOrder.Add(new ProductOrder { ProductName="pen", ProductAmount=4777, DeliveryDate="2021-06-30"});
            _context.ProductOrder.Add(new ProductOrder { ProductName = "apple", ProductAmount = 2000, DeliveryDate = "2021-05-30" });
            _context.ProductOrder.Add(new ProductOrder { ProductName = "curd", ProductAmount = 500, DeliveryDate = "2021-01-30" });
            _context.ProductOrder.Add(new ProductOrder { ProductName = "bat", ProductAmount =20000, DeliveryDate = "2020-09-21" });
            _context.ProductOrder.Add(new ProductOrder { ProductName = "pen", ProductAmount = 100, DeliveryDate = "2021-01-12" });
            _context.SaveChanges();
        }

        public void AddingDatatoProductsupplier()
        {
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 1, SupplierId = 1 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 1, SupplierId = 2 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 1, SupplierId = 3 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 2, SupplierId = 3 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 2, SupplierId = 4 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 2, SupplierId = 6 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 3, SupplierId = 1 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 3, SupplierId = 2 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 3, SupplierId = 5 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 2, SupplierId = 5 });
            _context.ProductSupplier.Add(new ProductSupplier { ProductId = 1, SupplierId = 6});
            _context.SaveChanges();
        }
    }
}
