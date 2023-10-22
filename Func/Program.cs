using System;
using Func.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Func
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(NameUpper).ToList(); // passando método por referência

            List<string> result1 = list.Select(func).ToList(); //Passando Func com referência no método

            List<string> result2 = list.Select(p => p.Name.ToUpper()).ToList();//passando lambda




            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

        }

        static string  NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
     
    }
}