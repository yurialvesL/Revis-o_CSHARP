using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExLinq2.Entities;


namespace ExLinq2
{
    public class Program
    {
        public static void Main(string[] args)
        {
			List<Employee> employees = new List<Employee>();
			try
			{
				Console.Write("Enter full file path:");
				string file = Console.ReadLine();
				using (StreamReader r = File.OpenText(file))
				{
					while (!r.EndOfStream)
					{
						string[] line = r.ReadLine().Split(',');
						Employee employee = new Employee(line[0], line[1], double.Parse(line[2],CultureInfo.InvariantCulture));
						employees.Add(employee);
						
					}
				}
                Console.WriteLine("Email of people whose salary is more than 2000:");
                employees.ForEach(e =>
				{
					if (e.Salary >= 2000)
						Console.WriteLine(e.Email);
				});

                var result = employees.Where(e => e.Name.StartsWith('M')).Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);
                Console.Write($"Sum of salary of people whose name starts with 'M':{result}");

            }
			catch (Exception e)
			{
                Console.WriteLine($"An erros as ocurred:{e.Message}");
                throw;
			}

        }

    }
}