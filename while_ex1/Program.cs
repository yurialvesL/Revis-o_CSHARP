using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace while_ex1;

public static class Program
{
    public static void Main()
    {
        string senha = "2023";

        Console.WriteLine("Digite a senha:");
        string cs = Console.ReadLine();

        while (cs != senha)
        {
            Console.WriteLine("Senha invalida");
            Console.WriteLine("Digite a senha:");
             cs = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido");

    }
}