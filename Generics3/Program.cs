using System;
using Generics3.Entities;


//GetHashCode and Equals
namespace Generics3
{
    public class Program
    {
        public static void Main()
        {
            Client a  =  new Client("Maria","maria@gmail.com");
            Client b = new Client("Yuri", "yuri@gmail.com");

            Console.WriteLine(a.Equals(b)); // com base na sobreposição criada na classe
            Console.WriteLine(a == b); // verificando pelo numero na memória
            Console.WriteLine(a.GetHashCode()); // com base na sobreposição criada na classe
            Console.WriteLine(b.GetHashCode()); // com base na sobreposição criada na classe

        }
    }
}