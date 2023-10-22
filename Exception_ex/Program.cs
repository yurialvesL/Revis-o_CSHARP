using System;
using Exception_ex.Exception;
using Exception_ex.Entities;

namespace Exception_ex;

public class Program
{
    public static void Main()
    {
       
        Console.WriteLine("Enter account data");
        Console.Write("Number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Holder:");
        string name = Console.ReadLine();
        Console.Write("Initial balance:");
        double iBalance = double.Parse(Console.ReadLine());
        Console.Write("Wirhdraw Limit:");
        double limit = Convert.ToDouble(Console.ReadLine());
        Account conta =  new Account(number,name,iBalance,limit);

        Console.Write("Enter amount for withdraw:");
        double withdraw = double.Parse(Console.ReadLine());
        conta.withdraw(withdraw);








    }
}