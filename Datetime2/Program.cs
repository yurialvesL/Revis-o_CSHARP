using System;
using System.Globalization;




public class Program
{
    public static void Main()
    {
        //Propriedades do DateTime
        DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        Console.WriteLine(d);
        Console.WriteLine("Propriedades do DateTime:");
        Console.WriteLine($"1) Date: {d.Date}");
        Console.WriteLine($"2)Day: {d.Day}");
        Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
        Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
        Console.WriteLine($"5) Hour: {d.Hour}");
        Console.WriteLine($"6) Kind: {d.Kind}");
        Console.WriteLine($"7) Milisecond: {d.Millisecond}");
        Console.WriteLine($"8) Minute: {d.Minute}");
        Console.WriteLine($"9) Month: {d.Month}");
        Console.WriteLine($"10) Second: {d.Second}");
        Console.WriteLine($"11) TimeOfDay: {d.TimeOfDay}");
        Console.WriteLine($"12) Year: {d.Year}");
        Console.WriteLine($"13) Ticks: {d.Ticks}");
        Console.WriteLine("-------------------------------");
        //----------------------------------------------
        //Conversões 
        Console.WriteLine("Conversões");
        string s1 = d.ToLongDateString();
        string s2 = d.ToLongTimeString();
        string s3 = d.ToShortDateString();
        string s4 = d.ToShortTimeString();
        string s5 = d.ToString();
        string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
        string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
        Console.WriteLine("-------------------------------------");
        // Funções de adição e subtração de datas
        DateTime d2 = d.AddHours(2);
        DateTime d3 = d.AddMinutes(4);
        TimeSpan d4 = d2.Subtract(d);
        Console.WriteLine(d);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
    }
}