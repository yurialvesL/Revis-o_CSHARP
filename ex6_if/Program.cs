using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace ex6_if;

public static class Program
{
    public static void Main()
    {
        double n = 0;
        Console.WriteLine("Digite um numero");
        n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        if (n > 0  && n <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (n > 25 && n <= 50)
        {
            Console.WriteLine("Intervalo [25,50]");
        }
        else if (n>50 && n <=75)
        {
            Console.WriteLine("Intervalo [50,75]");
        }
        else if (n >75  && n <= 100)
        {
            Console.WriteLine("Intervalo [75,100]");
        }
        else
        {
            Console.WriteLine("Fora do intervalo");
        }

    }
}
