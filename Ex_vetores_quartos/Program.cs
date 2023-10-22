using System;
using Ex_vetores_quartos;



public class Program
{
    public static void Main()
    {
        Estudante[] quartos = new Estudante[10];

        Console.Write("How many room will be rented?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Rent #{i+1}:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int quarto = Convert.ToInt32(Console.ReadLine());

            quartos[quarto] = new Estudante(nome, email, quarto);
        }
        Console.WriteLine("Busy rooms:");
        for (int i = 0; i < quartos.Length; i++)
        {
            if(quartos[i] == null) { continue; }
            Console.WriteLine($"{i}:{quartos[i]._nome},{quartos[i]._email}");
        }


    }
}