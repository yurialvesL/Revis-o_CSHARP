using System;
using Enum_rev.Entities;
using Enum_rev.Entities.Enums;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Order order = new Order
        {
            Id = 1080,
            Moment = new DateTime(),
            Status = OrderStatus.PendingPayment

        };
        Console.WriteLine(order.ToString());

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(os);
        Console.WriteLine(txt);
    }
}