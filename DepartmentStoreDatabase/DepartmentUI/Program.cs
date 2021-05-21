using DepartmentUI.Controllers;
using DepartmentUI.DatabaseOperations;
using System;

namespace DepartmentUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentOperations Operations = new DepartmentOperations();
            //Operations.AddingDataToRoles();
            //////Operations.AddingDataToStaffTable();
            //////Operations.AddingDataToStaffAddress();
            ////Operations.AddingDataToCategory();
            //Operations.AddingDataToProduct();
            //Operations.AddingDataToInventory();
            //Operations.AddingDataToProductPrice();
            //Operations.AddingDataToProductOrder();
            //Operations.AddingDataToSuppliers();
            //Operations.AddingDatatoProductsupplier();

             DepartmentQuerries Query = new DepartmentQuerries();
            //Query.QuerriesOnStaffTable();
            Query.QuerriesRelatedProductandSupplier();
        }
    }
}
