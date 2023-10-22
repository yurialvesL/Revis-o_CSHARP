using System;
using System.Collections.Generic;
using System.IO;


namespace Dictionary_EX1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string,int> votos = new Dictionary<string,int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        if (!(votos.ContainsKey(line[0])))
                        {
                            votos.Add(line[0], int.Parse(line[1]));
                        }
                        else
                        {
                            votos[line[0]] += int.Parse(line[1]);
                        }

                    }
                }
                foreach(KeyValuePair<string,int> a in votos)
                {
                    Console.WriteLine($"{a.Key}:{a.Value}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error as occurred: {ex.Message}");
            }

        }
    }
}