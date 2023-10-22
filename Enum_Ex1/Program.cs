using Enum_Ex1.Entities;
using Enum_Ex1.Entities.Enum;
using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        HourContract contrato = new HourContract();
        string department = "";
        Console.Write("Enter department's name:");
        department = Console.ReadLine();
        Department dp = new Department(department);
        Console.WriteLine("Enter worker data:");
        Console.Write("Name:");
        string nome= Console.ReadLine();
        Console.Write("Level(Junior/MidLevel/Senior):");
        string l =  Console.ReadLine();
        WorkerLevel level = Enum.Parse<WorkerLevel>(l); 
        Console.Write("Base salary:");
        double bSalary = double.Parse(Console.ReadLine());

        Console.WriteLine("How many contracts to this worker?");
        int contratos = int.Parse(Console.ReadLine());

        Worker worker = new Worker(nome, level, bSalary, dp);

        for (int i=0; i<contratos; i++)
        {
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date(DD/MM/YYYY):");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Value per hour:");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Duration (hours):");
            int duration = int.Parse(Console.ReadLine());
            contrato = new HourContract(dataContrato, valor, duration);
            worker.AddContract(contrato);
        }
        
        
        Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
        DateTime monthYear = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Department: {worker.Department.Name}");
        Console.WriteLine($"Income for {monthYear:MM/yyyy}   " + worker.Income(monthYear.Year, monthYear.Month).ToString("F2", CultureInfo.InvariantCulture));
        
    }
}