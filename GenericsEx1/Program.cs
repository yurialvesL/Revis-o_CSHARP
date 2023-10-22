using System;
using System.IO;
using System.Collections.Generic;
using GenericsEx1.Entities;

namespace GenericsEx1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<Log> logs = new HashSet<Log>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string [] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        logs.Add(new Log { Nome = name, Instant = instant });
                        
                    }
                }
                Console.WriteLine($"Total users: {logs.Count}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}