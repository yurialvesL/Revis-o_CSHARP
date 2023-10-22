using System;
using System.Collections.Generic;
using System.Linq;

namespace Revisão_CSHARP;

public static class Program
{
    public static void Main()
    {
        int n = 0;

        Console.WriteLine("Digite um número");
        n = int.Parse(Console.ReadLine());


        if (n == 0 || n > 0)
        {
            Console.WriteLine("Não Negativo");
        }
        else
        {
            Console.WriteLine("Negativo");
        }
        
    }
}