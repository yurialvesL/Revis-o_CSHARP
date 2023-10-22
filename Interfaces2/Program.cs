using System;
using System.Collections.Concurrent;
using System.Globalization;
using Interfaces2.Entities;
using Interfaces2.Services;


namespace Interfaces2
{
    public static class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number:");
            int contract = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract value:");
            double amount = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments:");
            int parcelas = Convert.ToInt32(Console.ReadLine());
            Contract c = new Contract(contract, date, amount, new List<Installment> { });
            ContractService cs = new ContractService();
            cs.processContract(c, parcelas);
        }
    }
}