using System;
using System.Globalization;


public class Program
{
    public static void Main()
    {
        DateTime d1 = new DateTime(2018, 11, 25);
        DateTime d2 = new DateTime(2018,11,25,20,45,03);
        DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;
        
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d5);
        Console.WriteLine(d6);

        //-----------------------------------------------
        //Com o Parse é possivel formata uma string em data para o tipo DateTime conforme exemplo abaixo:
        DateTime d7 = DateTime.Parse("2000-08-15");
        DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d9 = DateTime.Parse("15/08/2000 ");
        DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
        Console.WriteLine(d7);
        Console.WriteLine(d8);
        Console.WriteLine(d9);
        Console.WriteLine(d10);
        //-----------------------------------
        //Com o ParseExact é possivel pegar uma string em data em um formato fora do padrão e converter para DateTime
        DateTime dp = DateTime.ParseExact("2010-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
        DateTime dp2 = DateTime.ParseExact("15/08/2002 13:05:47", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
        Console.WriteLine(dp);
        Console.WriteLine(dp2);
    }
}