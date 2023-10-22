using System;
using System.Linq;
using System.Collections.Generic;
using Linq2.Entities;
using System.Net.WebSockets;

namespace Linq2
{
    public class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1};

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1,Name = "Computer",Price = 1100.00, Category= c2},
                new Product() { Id = 2,Name = "Hammer",Price = 90.0, Category= c1},
                new Product() { Id = 3,Name = "TV",Price = 1700.0, Category= c3},
                new Product() { Id = 4,Name = "Notebook",Price = 1300.0, Category= c2},
                new Product() { Id = 5,Name = "Saw",Price = 80.0, Category= c1},
                new Product() { Id = 6,Name = "Tablet",Price = 700.0, Category= c2},
                new Product() { Id = 7,Name = "Camera",Price = 700.0, Category= c3},
                new Product() { Id = 8,Name = "Printer",Price = 350.0, Category= c3},
                new Product() { Id = 9,Name = "MacBook",Price = 1800.0, Category= c2},
                new Product() { Id = 10,Name = "SoundBar",Price = 700.0, Category= c3},
                new Product() { Id = 11,Name = "Level",Price = 70.0, Category= c1}

            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900).ToList(); Padrão linq
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p; //estilo sql
            Print("Tier 1 and Price < 900:", r1);



            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); Padrão linq

            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name; //estilo sql
            Print("Names of products from tools", r2);

            var rd = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //Padrão linq
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                }; //estilo sql
            Print("Names started with C and Anonymous Object ", r3);

            var rw = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); //Padrão linq
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p; //estilo sql
            Print("Tier 1 order by price then by Name", r4);

            //var r5 = r4.Skip(2).Take(4); Padrão linq
            var r5 = (from p in r4
                     select p).Skip(2).Take(4); //estilo sql
            Print("Tier 1 order by price then by Name SKIP 2 TAKE 4", r5);

            //var r6 = products.FirstOrDefault(); Padrão linq
            var r6 = (from p in products select p).FirstOrDefault(); //estilo sql
            Console.WriteLine("First test1:"+ r6);

            //var r7 = products.Where(p => p.Price > 3000).FirstOrDefault(); padrão linq
            var r7 = (from p in products where p.Price > 3000 select p).FirstOrDefault();

            Console.WriteLine("First or default  test2:"+r7);
            Console.WriteLine();


            var r8 =  products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1:"+r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test1:" + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price:"+r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price:"+ r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum per category:"+r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average per category:" + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average prices check value empty: "+ r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum:"+r15);

            Console.WriteLine();
            //var r16 = products.GroupBy(p => p.Category); padrão linq
            var r16 = from p in products
                      group p by p.Category; //estilo sql

            foreach (IGrouping<Category,Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name}: " );
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }





        }
    }
}