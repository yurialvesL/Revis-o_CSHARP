using System;
using Enum_Ex3.Entities;
using Enum_Ex3.Entities.Enum;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Enter cliente data:");
        Console.Write("Name:");
        string name = Console.ReadLine();

        Console.Write("Email:");
        string email = Console.ReadLine();

        Console.Write("Bith date (DD/MM/YYYY): ");
        DateTime birth = DateTime.Parse(Console.ReadLine());
        Client client = new Client(name,email,birth);

        Console.WriteLine("Enter order data:");

        Console.Write("Status:");
        string s = Console.ReadLine();
        OrderStatus orderStatus = Enum.Parse<OrderStatus>(s);

        Console.Write("How many items to this order?");
        int orders = int.Parse(Console.ReadLine());


        Order order = new Order(orderStatus,client);
        for (int i = 0; i<orders; i++)
        {
            Console.WriteLine($"Enter #{i+1} item data");
            Console.Write("Product Name:");
            string prodName = Console.ReadLine();
            Console.Write("Product price");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            int qtd = int.Parse(Console.ReadLine());
            Product product = new Product(prodName,price);
            OrderItem item = new OrderItem(qtd,price,product);
            order.AddItem(item);


        }
        Console.WriteLine(order);


    }
}