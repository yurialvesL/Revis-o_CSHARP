using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interfaces.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment:\n{BasicPayment.ToString("F2",CultureInfo.InvariantCulture)}\n Tax:\n {Tax.ToString("F2",CultureInfo.InvariantCulture)} \nTotal payment:\n{TotalPayment.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
