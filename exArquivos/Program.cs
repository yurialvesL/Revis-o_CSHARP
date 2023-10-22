using System;
using System.Globalization;
using System.IO;
using exArquivos.Entities;

namespace exArquivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = null;
            string path = @"C:\Users\Yuri\source\repos\Revisão_CSHARP\exArquivos\Resources\produtos.csv";
            string outpath = @"C:\Users\Yuri\source\repos\Revisão_CSHARP\exArquivos\Resources\out";
            List<Products> prods = new List<Products>();

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] produto = sr.ReadLine().Split(",");
                    
                    Products products = new Products(produto[0], Convert.ToDouble(produto[1],CultureInfo.InvariantCulture), Convert.ToInt32(produto[2]));
                    prods.Add(products);
                   
                    
                }



                if (!Directory.Exists(outpath))
                {
                    Directory.CreateDirectory(outpath);
                }
                using (StreamWriter sw = File.AppendText(outpath+@"\summary.csv"))
                {
                    foreach(Products p in prods)
                    {
                        sw.WriteLine(p.ToString());
                    }
                }


            }
            catch (IOException e)
            {

                Console.WriteLine($"An Error Occurred: \n{e.Message}");
            }
        }
    }
}