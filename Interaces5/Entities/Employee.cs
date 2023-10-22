using System.Globalization;
using System;

namespace Interfaces5.Entities
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) 
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1],CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("cOMPARING ERROR: ARGUMENT IS NOT AN EMPLOYEE");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
