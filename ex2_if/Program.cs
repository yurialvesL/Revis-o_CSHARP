using System;
using System.Collections.Generic;
using System.Linq;

namespace ex2_if;

public static class Program
{
    public static void Main()
    {
        int n = 0;
        Console.WriteLine("Digite um numero:");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }

}
