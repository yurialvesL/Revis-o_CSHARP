﻿using System;
using Predicate.Entities;
using System.Collections.Generic;

namespace Predicate
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

            list.RemoveAll(p => p.Price >= 100.0); //exemplo com Lambda
            //list.RemoveAll(ProductTest); exemplo passando função por referência

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool ProductTest(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}