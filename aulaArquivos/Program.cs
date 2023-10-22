using System;
using System.IO;



namespace aulaArquivos
{
    public static class Program
    {
        public static void Main()
        {
            string sourcePath = @"c:\temp\file1.txt";

            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] LINES = File.ReadAllLines(fileInfo.FullName);
                foreach (string line in LINES)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"An error occurred \n {e.Message}");
            }



        }
    }
    
}