using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace while_ex1;

public static class Program
{
    public static void Main()
    {
        int alcool=0,gasosa=0,diesel=0,escolha = 0;

        Console.WriteLine("Digite uma das seguintes opções:\n1-álcool\n2-Gasolina\n3-Diesel\n4-Sair");
        escolha = int.Parse(Console.ReadLine());
        while (escolha != 4)
        {
            if (escolha == 1)
            {
                alcool++;
            }
            else if (escolha == 2)
            {
                gasosa++;
            }
            else if (escolha == 3)
            {
                diesel++;
            }
            Console.WriteLine("Digite uma das seguintes opções:\n1-álcool\n2-Gasolina\n3-Diesel\n4-Sair");
            escolha = int.Parse(Console.ReadLine());


        }
        Console.WriteLine("Muito Obrigado");
        Console.WriteLine($"Alcool: {alcool}\nGasosa: {gasosa} \n diesel: {diesel}");
        


    }
}