using System;
using System.Linq;
using System.Collections.Generic;

namespace Herança_Ex1;

class OutsourcedEmployee : Employee
{
    public double ExtraMoney { get; set; }

    public OutsourcedEmployee() { }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double extraMoney):base( name,  hours,  valuePerHour)
    {
        ExtraMoney = extraMoney;
    }

    public override double TotalSalary()
    {
        return base.TotalSalary() + (ExtraMoney*1.1);
    }

}