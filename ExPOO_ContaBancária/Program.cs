using System;
using System.Globalization;
using ExPOO_ContaBancária;



public static class Program
{
    public static void Main()
    {
        double valor_depoInicial = 0.00;

        ContaBancaria conta = null;


       Console.Write("Entre o número da conta:");
        
        string numeroConta = Console.ReadLine();
        
        Console.Write("Entre o titular da conta:");
        
        string nomeTitular = Console.ReadLine();
        
        Console.Write("Haverá depósito inicial (s/n)?");
        
        string depositoInicial = Console.ReadLine();
        
        if (depositoInicial.ToUpper() == "S")
        {
            Console.Write("Entre com o valor de depósito inicial:");
            valor_depoInicial = Convert.ToDouble(Console.ReadLine());

             conta = new ContaBancaria(numeroConta, nomeTitular,valor_depoInicial);
        }
        else
        {

             conta = new ContaBancaria(numeroConta, nomeTitular);
            
        }
        Console.WriteLine("Dados da conta:");
        Console.WriteLine($"Conta {conta._conta}, Titular:{conta._nome}, Saldo:$ {conta._saldo}");

        Console.Write("Entre com o valor de depósito:");
        valor_depoInicial = Convert.ToDouble(Console.ReadLine());
        conta.deposito(valor_depoInicial);

        Console.WriteLine("Dados da conta atualizados:");

        Console.WriteLine($"Conta {conta._conta}, Titular:{conta._nome}, Saldo:$ {conta._saldo}");

        Console.Write("Entre com o valor de saque:");
        double saqueVal = Convert.ToDouble(Console.ReadLine());
        conta.saque(saqueVal);

        Console.WriteLine("Dados da conta atualizados:");

        Console.WriteLine($"Conta {conta._conta}, Titular:{conta._nome}, Saldo:$ {conta._saldo}");






    }
}
