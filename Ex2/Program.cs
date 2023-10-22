using Ex2.Entities;
using System;
using System.Globalization;
using System.Linq;


namespace Herança_Ex2
{
    public class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>() { };
            Console.Write("Enter the number of products:");
            int pds = int.Parse(Console.ReadLine());
            for(int i = 0; i < pds; i++)
            {
                Console.Write("Common,used or imported (c/u/i)");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());
                if(type.ToString() == "i")
                {
                    Console.Write("Custom fee:");
                    double custom = double.Parse(Console.ReadLine());
                    ImportedProduct importedProduct = new ImportedProduct(name,price,custom);
                    products.Add(importedProduct);
                }
                else if(type.ToString() == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY)");
                    DateTime dt =DateTime.Parse(Console.ReadLine());
                    UsedProduct used = new UsedProduct(name,price,dt);
                    products.Add(used);
                }
                else
                {
                    Product product = new Product(name,price);
                    products.Add(product); 
                }
            }
            Console.WriteLine("Price Tags:");
            foreach(Product p in products)
            {
                Console.WriteLine($"{p.PriceTag()}");
            }
        }
    }
}