using System;
using System.Collections.Generic;
using System.Linq;

namespace ex4_if;

public static class Program
{
    public static void Main()
    {
        int hi = 0;
        int hf = 0;
        int ht = 24;
        Console.WriteLine("Digite a hora inicial:");
        hi = int.Parse(Console.ReadLine());
        Console.WriteLine("Digita a hora final");
        hf = int.Parse(Console.ReadLine());

        if (hi > hf)
        {
            ht = (ht - hi) + hf;
            Console.WriteLine($"O JOGO DUROU {ht} HORA(S)");

        }
        else if (hi < hf )
        {
            ht = hf- hi;
            Console.WriteLine($"O JOGO DUROU {ht} HORAS(S)");
        }
        else if (hi == 0 && hf == 0)
        {
            Console.WriteLine($"O JOGO DUROU {ht} HORAS(S) ");
        }
    }
}
