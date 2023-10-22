using System;



namespace Generics1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i =0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.addValue(x);
            }




            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First:"+ printService.First());
        }
    }
}