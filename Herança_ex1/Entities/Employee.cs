using System;
using System.Linq;
using System.Collections.Generic;

namespace Herança_Ex1;

class Employee
{
    public string Name { get; set; }
    public int Hours { get; set; }
    public double ValuePerHour { get; set; }

    public Employee() { }

    public Employee(string name, int hours, double valuePerHour)
    {
        Name = name;
        Hours = hours;
        ValuePerHour = valuePerHour;
    }

    public virtual double TotalSalary()
    {
        return (Hours * ValuePerHour);
    }
}