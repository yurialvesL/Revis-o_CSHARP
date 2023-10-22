using System;
using System.Collections.Generic;
using métodos_abstratos.Entities;
using métodos_abstratos.Enum;


public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();
        Console.Write("Enter the number of shapes:");
        int ips = int.Parse(Console.ReadLine());
        for(int i = 0; i<ips; i++)
        {
            Console.Write("Rectangle or Circle (r/c)?");
            char c = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red):");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (c.ToString() == "r")
            {
                Console.WriteLine("Digite a largura");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura:");
                double height = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(color, width, height);
                shapes.Add(rectangle);
            }
            else
            {
                Console.WriteLine("Raio do circulo");
                double raio = double.Parse(Console.ReadLine());
                Circle circulo = new Circle(color, raio);
                shapes.Add(circulo);
            }
        }
        Console.WriteLine("SHAPE AREAS:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.Area()}");
        }
       

    }
}