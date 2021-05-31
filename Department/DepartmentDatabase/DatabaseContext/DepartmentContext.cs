using DepartmentDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentDatabase.DatabaseContext
{
    public class DepartmentContext:DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Suppliers> Supplier { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<ProductSupplier> ProductSupplier { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;DataBase=DatabaseDepartment;username=postgres;password=harsh");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasKey(s => s.Id);
            modelBuilder.Entity<Staff>().Property(s => s.FirstName).HasMaxLength(64);
            modelBuilder.Entity<Staff>().Property(s => s.LastName).HasMaxLength(64);
            modelBuilder.Entity<Staff>().Property(s => s.PhoneNo).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().Property(s => s.Salary).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().Property(s => s.Gender).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().HasOne(s => s.Role).WithMany(g => g.Staff).HasForeignKey(s => s.RoleId);

           
            modelBuilder.Entity<Address>().HasKey(s => s.Id);
            modelBuilder.Entity<Address>().Property(s => s.StaffAddress).HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(s => s.State).HasMaxLength(20);
            modelBuilder.Entity<Address>().Property(s => s.City).HasMaxLength(20);
            modelBuilder.Entity<Address>().Property(s => s.PinCode).HasMaxLength(10);
            modelBuilder.Entity<Address>().HasOne(s => s.staff).WithOne().HasForeignKey<Address>(s => s.StaffId);

            modelBuilder.Entity<Role>().HasKey(s => s.Id);
            modelBuilder.Entity<Role>().Property(s => s.StaffRole).HasMaxLength(30);
            modelBuilder.Entity<Role>().Property(s => s.RoleDescription).HasMaxLength(100);
            //modelBuilder.Entity<Role>().HasOne(s=>s.Staff).WithMany(g=>g.)


            modelBuilder.Entity<Product>().HasKey(s => s.Id);
            modelBuilder.Entity<Product>().Property(s => s.ProductName).HasMaxLength(30);
            modelBuilder.Entity<Product>().Property(s => s.ProductBrand).HasMaxLength(30);
            modelBuilder.Entity<Product>().Property(s => s.CategoryId).IsRequired();
            modelBuilder.Entity<Product>().HasOne(s => s.Category).WithMany(g => g.product).HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<Category>().HasKey(s => s.Id);
            modelBuilder.Entity<Category>().Property(s => s.CategoryName).HasMaxLength(30);
            modelBuilder.Entity<Category>().Property(s => s.Categorydescription).HasMaxLength(30);
            //modelBuilder.Entity<Category>().HasOne(s => s.Product).WithOne().HasForeignKey<Category>(s => s.ProductId);

            modelBuilder.Entity<Inventory>().HasKey(s => s.Id);
            modelBuilder.Entity<Inventory>().Property(s => s.Quantity).IsRequired();
            modelBuilder.Entity<Inventory>().Property(s => s.IsInStock).IsRequired();
            modelBuilder.Entity<Inventory>().Property(s => s.productId).IsRequired();
            modelBuilder.Entity<Inventory>().HasOne(s => s.product).WithOne().HasForeignKey<Inventory>(s => s.productId);

            modelBuilder.Entity<ProductPrice>().HasKey(s => s.Id);
            modelBuilder.Entity<ProductPrice>().Property(s => s.productId).IsRequired();
            modelBuilder.Entity<ProductPrice>().HasOne(s => s.product).WithOne().HasForeignKey<ProductPrice>(s => s.productId);


            modelBuilder.Entity<ProductSupplier>().HasKey(s => new { s.ProductId, s.SupplierId });
            modelBuilder.Entity<ProductSupplier>().HasOne(s => s.product).WithMany(g => g.ProductSuppliers).HasForeignKey(s => s.ProductId);
            modelBuilder.Entity<ProductSupplier>().HasOne(s => s.suppliers).WithMany(g => g.ProductSuppliers).HasForeignKey(s => s.SupplierId);

            modelBuilder.Entity<Suppliers>().HasKey(s => s.Id);
            modelBuilder.Entity<Suppliers>().Property(s => s.SupplierName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Suppliers>().Property(s => s.PhoneNo).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Suppliers>().Property(s => s.EmailAddress).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Suppliers>().HasOne(s => s.productOrder).WithMany(g => g.Supplier).HasForeignKey(s => s.ProductOrderId);


            modelBuilder.Entity<ProductOrder>().HasKey(s => s.Id);
            modelBuilder.Entity<ProductOrder>().Property(s => s.ProductName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<ProductOrder>().Property(s => s.ProductAmount).IsRequired();
            modelBuilder.Entity<ProductOrder>().Property(s => s.DeliveryDate).IsRequired();


        }

    }
    }
