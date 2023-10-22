using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Specificar o data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Definir a query expression
            var result = numbers
                .Where(n => n % 2 == 0)
                .Select(p => p*10).ToList();

            // Execute the query
            foreach(int n in result)
            {
                Console.WriteLine(n);
            }

        }
    }
}