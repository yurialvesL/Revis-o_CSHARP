using System;
using System.IO;
using System.Collections.Generic;
using Interfaces5.Entities;

namespace Interfaces5
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Yuri\AppData\Local\Temp\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                        
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"An error occurred:{e.Message}");
            }
        }
    }
}