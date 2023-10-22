using System;



namespace POO02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Digite o dado do produto");
            product.Name = Console.ReadLine();
            Console.WriteLine("Digite a quantidade");
            product.Qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço:");
            product.Price = double.Parse(Console.ReadLine());

            product.AddProd(5);
            Console.WriteLine();
        }

}   }