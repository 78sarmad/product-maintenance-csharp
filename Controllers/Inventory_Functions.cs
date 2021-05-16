using Product_Maintenance.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Maintenance.Controllers
{
    class Inventory_Functions
    {
        static readonly string filePath = @"Products.txt";
        Inventory inventory;
        public Inventory_Functions()
        {
            createFileIfNotExists();
            inventory = new Inventory();
        }

        private void createFileIfNotExists()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                Console.WriteLine("File created.");
            }
            else
            {
                Console.WriteLine("File already exists.");
            }
        }

        public List<Product> LoadProducts()
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string line;

                // Read all text line by line
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("File loaded.");

                Product prod = new Product();
                int total_attributes = 6;
                int lineCount = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    switch (lineCount)
                    {
                        case 1:
                            prod.ID = Int32.Parse(line);
                            break;
                        case 2:
                            prod.Name = line;
                            break;
                        case 3:
                            prod.Price = Convert.ToDouble(line);
                            break;
                        case 4:
                            prod.MFG_Date = line;
                            break;
                        case 5:
                            prod.Expiry_Date = line;
                            break;
                        case 6:
                            prod.Discontinued = Convert.ToBoolean(line);
                            break;
                    }

                    // skips empty lines
                    if (lineCount != total_attributes && line != "")
                    {
                        lineCount++;
                        continue;
                    }

                    // add product to inventory list
                    this.inventory.Products.Add(prod);
                    Console.WriteLine(prod.Name + prod.Price + prod.MFG_Date + prod.Expiry_Date + prod.Discontinued);

                    // reset count and product
                    lineCount = 1;
                    prod = new Product();
                }

                sr.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("No products found.");
            }


            return inventory.Products;
        }

        public void SaveProduct(Product prod)
        {
            // write product to file, append mode is set to true
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(prod.ID);
                writer.WriteLine(prod.Name);
                writer.WriteLine(prod.Price);
                writer.WriteLine(prod.MFG_Date);
                writer.WriteLine(prod.Expiry_Date);
                writer.WriteLine(prod.Discontinued);
            }
        }

    }
}