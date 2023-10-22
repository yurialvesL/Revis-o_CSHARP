using System;
using System.IO;


namespace aulaArquivo5
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                // listar pastas a partir de uma pasta informada

                var folders =  Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //listar arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path+@"\newFolder");
            }
            catch (IOException e)
            {

                Console.WriteLine($"An error occurred \n {e.Message}");
            }
        }
    }
}