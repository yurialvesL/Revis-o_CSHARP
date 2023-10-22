using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Enum_Ex1.Entities;
using Enum_Ex1.Entities.Enum;

namespace Enum_Ex1.Entities
{
    public class Worker 
    {
        public string Name { get; set; }
        WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contratos { get; private set; } = new List<HourContract>();
        
        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContract(HourContract contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Income(int year, int month)
        {
            double _income = 0.0;
            
            foreach (HourContract contrato in Contratos)
            {
                if (contrato.date.Month == month && contrato.date.Year == year)
                {
                    _income += contrato.TotalValue();
                }
            }
            _income += BaseSalary;

            return Math.Round(_income, 2);
        }
    }
}
