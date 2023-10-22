using System;
using System.Globalization;

namespace POO_EX2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee f1 = new Employee();
            Employee f2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Name:");
            f1.Name = Console.ReadLine();
            Console.Write("Salary:");
            f1.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Name:");
            f2.Name = Console.ReadLine();
            Console.Write("Salary:");
            f2.salary = double.Parse(Console.ReadLine());

            double avg = (f1.salary + f2.salary) / 2;
            Console.WriteLine($"Average Salary = {avg.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
