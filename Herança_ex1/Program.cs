using System;
using System.Linq;
using System.Globalization;


namespace Herança_Ex1;

public static class Program
{
    public static void Main()
    {
        Console.Write("How many employees you want to register?");
        int e = int.Parse(Console.ReadLine());
        List<Employee> empregados = new List<Employee> { };
        for (int i = 0; i < e; i++)
        {
            Console.Write($"Employee #{i + 1}:");
            Console.Write("What is the employee name?");
            string employName = Console.ReadLine();
            Console.Write("Outsourced Employee(y/n)?");
            char t = char.Parse(Console.ReadLine());
           
            Console.Write("Hours Worked?");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour?");
            double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(t.ToString() == "y")
            {
                Console.Write("Taxa adicional:");
                double taxAdt = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                OutsourcedEmployee emp = new OutsourcedEmployee(employName, hours, valueHour, taxAdt);
                empregados.Add(emp);
            }
            else
            {
                Employee employee = new Employee(employName, hours, valueHour);
                empregados.Add(employee);
            }


        }

        Console.WriteLine("Payments");
        foreach (Employee emp in empregados)
        {
            Console.WriteLine($"{emp.Name} - {emp.TotalSalary()}");
        }
    }
}