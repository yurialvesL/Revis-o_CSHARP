using Interfaces.Entities;
using System;
using System.Globalization;
using Interfaces.Services;

namespace Interfaces
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model:");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.WriteLine("Enter price per hour:");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day:");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




            CarRental car = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour,day, new BrazilTaxService());

            rentalService.ProcessInvoice(car);


            Console.WriteLine("INVOICE");
            Console.WriteLine(car.Invoice);



        }
    }
}