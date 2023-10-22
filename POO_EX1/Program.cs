using System;



namespace POO_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Name =  Console.ReadLine();
            Console.Write("Idade");
            p1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Name}");
            }



        }
    }
}