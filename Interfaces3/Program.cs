using System;
using Interfaces3.model.Entities;
using Interfaces3.Enums;



namespace Interface3
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Colors.White};
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Colors.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}