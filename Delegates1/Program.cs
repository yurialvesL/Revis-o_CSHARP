using Delegates1.Services;
using System;


namespace Delegates1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);//CalculationService.Sum;

            double result = op.Invoke(a,b);

            Console.WriteLine(result);
        }
    }
}

