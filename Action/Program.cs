using System;
using Action.Entities;
using System.Collections.Generic;


namespace Action
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

            Action<Product> act = UpdatePrice; //Usando Action passando por referência uma função

            Action<Product> act1 = p => { p.Price += p.Price * 0.1; }; //Passando expressão lambda


            list.ForEach(p => { p.Price += p.Price * 0.1; });
            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
  
    }
}