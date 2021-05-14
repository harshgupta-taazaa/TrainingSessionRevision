using ProductLib.Entities;
using ProductLib.Services;
using System;

namespace ProductCatalog
{
    class Program
    {
        static string FilePath = @"C:\DocumentsC#\CsvDataFile.csv";
        static void Main(string[] args)
        {
            DisplayManager();
        }
        public static void DisplayManager()
        {
            Console.WriteLine("Level 1");
            Console.WriteLine("\t a)- Category");
            Console.WriteLine("\t b)- Product");
            Console.WriteLine("\t c)- Exit the App!");
            Console.WriteLine("Enter a key ....");
            string EnteredKey = Console.ReadLine();

            switch (EnteredKey.ToLower())
            {
                case "a":
                    DisplayCategorySection();
                    break;
                case "b":
                    DisplayProductSection();
                    //DisplayProductSection();
                    break;
                case "c":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        DisplayManager();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
        }
        public static  void DisplayProductSection()
        {
            Console.WriteLine("\t a. Enter a Product.");
            Console.WriteLine("\t b. List all products. ");
            Console.WriteLine("\t c. Delete a Product");
            Console.WriteLine("\t d. Search a Product");
            Console.WriteLine("Enter a Key..");
            string EnterKey = Console.ReadLine();

            switch (EnterKey.ToLower())
            {
                case "a":
                    DataService UsingDataServic = new DataService(FilePath);
                    UsingDataServic.AddTheDataInCSVfile();
                    DisplayManager();
                    break;
                case "b":
                    DataService UsingDataService = new DataService(FilePath);
                    UsingDataService.ShowTheAvailableDataInCSVfile("Product");
                    DisplayManager();
                    break;
                case "c":
                    DataService UsingDataServicee = new DataService(FilePath);
                    UsingDataServicee.DeleteItemInCSVFile("Product");
                    DisplayManager();

                    break;
                case "d":
                    DataService UsingDataServiceee = new DataService(FilePath);
                    UsingDataServiceee.SearchItemInCSVFile("Product");
                    DisplayManager();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        DisplayProductSection();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
        }

        public static void DisplayCategorySection()
        {
            Console.WriteLine("\t a. Enter a Category.");
            Console.WriteLine("\t b. List all Categories ");
            Console.WriteLine("\t c. Delete a Category");
            Console.WriteLine("\t d. Search a Category");


            string category = Console.ReadLine();

            switch (category.ToLower())
            {
                case "a":
                    DataService UsingDataServic = new DataService(FilePath);
                    UsingDataServic.AddTheDataInCSVfile();
                    DisplayManager();
                    break;
                case "b":
                    DataService UsingDataService = new DataService(FilePath);
                    UsingDataService.ShowTheAvailableDataInCSVfile("Category");
                    DisplayManager();

                    break;
                case "c":
                    DataService UsingDataServicee = new DataService(FilePath);
                    UsingDataServicee.DeleteItemInCSVFile("Category");
                    DisplayManager();
                    break;
                case "d":
                    DataService UsingDataServiceee = new DataService(FilePath);
                    UsingDataServiceee.SearchItemInCSVFile("Product");
                    DisplayManager();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        DisplayCategorySection();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
        }
    }
}
