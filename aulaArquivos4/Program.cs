using System;
using System.IO;


namespace aulaArquivos4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file1.txt";
            string targetpath = @"c:\temp\file2.txt";

            try
            {
                string[] lines =  File.ReadAllLines(sourcepath);
                using(StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"An error occurred \n {e.Message}");
            }
        }
    }
}