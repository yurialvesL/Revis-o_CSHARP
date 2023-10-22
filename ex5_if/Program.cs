using System;
using System.Collections.Generic;
using System.Linq;

namespace ex5_if;

public static class Program
{
    public static void Main()
    {
        double valor = 0.0;
        string[] codigo_qtd;
        string teste = "";
        

        Console.WriteLine("Digite o codigo e quantidade do item");
       
        codigo_qtd = Console.ReadLine().Split(' ');
        if (Convert.ToInt64(codigo_qtd[0]) == 1)
        {
            valor = 4.00 * Convert.ToInt64(codigo_qtd[1]);
            Console.WriteLine($"Total: R$ {valor}");
        }
        else if (Convert.ToInt64(codigo_qtd[0]) == 2)
        {
            valor = 4.50 * Convert.ToInt64(codigo_qtd[1]);
            Console.WriteLine($"Total: R$ {valor}");
        }
        else if (Convert.ToInt64(codigo_qtd[0]) == 3)
        {
            valor = 5.00 * Convert.ToInt64(codigo_qtd[1]);
            Console.WriteLine($"Total: R$ {valor}");
        }
        else if (Convert.ToInt64(codigo_qtd[0]) == 4)
        {
            valor = 2.00 * Convert.ToInt64(codigo_qtd[1]);
            Console.WriteLine($"Total: R$ {valor}");
        }
        else if (Convert.ToInt64(codigo_qtd[0]) == 5)
        {
            valor = 4.00 * Convert.ToInt64(codigo_qtd[1]);
            Console.WriteLine($"Total: R$ {valor}");
        }


    }
}
