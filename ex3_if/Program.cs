using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3_if;

public static class Program
{
    public static void Main()
    {
        int a = 0;
        int b = 0;

        Console.WriteLine("Digite o primeiro numero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        b = int.Parse(Console.ReadLine());

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("São multiplos");
        }
        else
        {
            Console.WriteLine("Não são multiplos");
        }
    }
}
