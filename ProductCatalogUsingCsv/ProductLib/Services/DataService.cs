﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using ProductLib.Entities;

namespace ProductLib.Services
{
    public class DataService
    {
        string FilePath { get; }
        public DataService(string filePath)
        {
            this.FilePath = filePath;
        }

        public void ShowTheAvailableDataInCSVfile()
        {

            using (StreamReader input = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(input, CultureInfo.InvariantCulture))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();

                
                foreach (var record in records)
                {
                    
                    Console.WriteLine($"{record.Id}  {record.name}  {record.price}  {record.CategoryName}");
                   
                }
            }
        }
        public void AddTheDataInCSVfile()
        {
            var recordss = new List<Product>();
            using (StreamReader input = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(input, CultureInfo.InvariantCulture))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();


                foreach (var record in records)
                {
                    recordss.Add(new Product { Id = Int32.Parse(record.Id), name = record.name, price =Int32.Parse( record.price), CategoryName = record.CategoryName });
                    //Console.WriteLine($"{record.Id}  {record.name}  {record.price}");

                }
            }
            Console.WriteLine("Enter Product Name ..");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Price ");
            int price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Category");
            string Category = Console.ReadLine();
            recordss.Add(new Product { Id = recordss.Count+1, name = productName, price = price ,CategoryName=Category });
            using (var writer = new StreamWriter(FilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(recordss);
            }
            recordss.Clear();
        }
        public void DeleteItemInCSVFile()
        {
            var recordss = new List<Product>();
            using (StreamReader input = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(input, CultureInfo.InvariantCulture))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();


                foreach (var record in records)
                {
                    recordss.Add(new Product { Id = Int32.Parse(record.Id), name = record.name, price = Int32.Parse(record.price) ,CategoryName=record.CategoryName});
                    

                }
            }
            Console.WriteLine("Enter Product Name");
            string ProductName = Console.ReadLine();
            recordss.RemoveAll(item => item.name == ProductName);
            using (var writer = new StreamWriter(FilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(recordss);
            }
            recordss.Clear();
        }

        public void SearchItemInCSVFile()
        {
            var recordss = new List<Product>();
            using (StreamReader input = File.OpenText(FilePath))
            using (CsvReader csvReader = new CsvReader(input, CultureInfo.InvariantCulture))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();


                foreach (var record in records)
                {
                    recordss.Add(new Product { Id = Int32.Parse(record.Id), name = record.name, price = Int32.Parse(record.price), CategoryName = record.CategoryName });


                }
            }
            Console.WriteLine("Enter Product Name");
            string ProductName = Console.ReadLine();
           
            foreach(var record in recordss)
            {
                if (record.name == ProductName)
                {
                    Console.WriteLine($"{record.Id}  {record.name}  {record.price}  {record.CategoryName}");
                }
            }


            
        }
    
    }
}
