using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using LinqEx1.Entities;
	
namespace LinqEx1
{
    public class Program
    {
        public static void Main()
        {
			List<Product> p = new List<Product>();
			try
			{
				Console.Write("Enter full file path:");
				using (StreamReader c  = File.OpenText(@Console.ReadLine()))
				{
					while (!c.EndOfStream)
					{
						string[] line = c.ReadLine().Split(",");
						p.Add(new Product() { Name = line[0], Price = double.Parse(line[1], CultureInfo.InvariantCulture) });
					}
				}
                
				double average = p.Select(m => m.Price).Average();
                Console.WriteLine($"Average price:{Math.Round(average,2)}");
                var nome = p.Where(m => m.Price < average).OrderByDescending(m => m.Name).Select(m => m.Name);
				foreach(string produto in nome)
				{
                    Console.WriteLine(produto);
                }


            }
			catch (Exception e)
			{

                Console.WriteLine($"An Error as occured:{e.Message}");
            }

        }
    }
}
