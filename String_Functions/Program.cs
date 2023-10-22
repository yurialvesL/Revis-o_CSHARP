using System;




public class Program
{
    public static void Main()
    {
        string original = "abcde FGHIJ ABC abc DEFG  ";

        string s1 = original.ToUpper(); //deixa tudo em letra maiuscula
        string s2 = original.ToLower(); //deixa tudo em letra minuscula

        string s3 = original.Trim(); // remove os espaços em branco

        int n1 = original.IndexOf("bc"); //retorna o indice da primeira ocorrencia especificada no parametro
        int n2 = original.LastIndexOf("bc");//retorna o indice da ultima ocorrencia especificada no parametro

        string s4 = original.Substring(3); //recorta string

        string s5 = original.Substring(3,5); // recorta string

        string s6 = original.Replace("a", "x"); //trocar um caractere ou string por outra
        string s7 = original.Replace("abc", "xy");//trocar um caractere ou string por outra

        bool b1 = String.IsNullOrEmpty(original); //verifica se a string é nula ou vazia
        bool b2 = String.IsNullOrWhiteSpace(original); // verifica se a string é nula ou espaço em branco

        Console.WriteLine($"Original: - {original} -");
        Console.WriteLine($"ToUpper:- {s1} - ");
        Console.WriteLine($"ToLower: -{s2} - ");
        Console.WriteLine($"Trim: -{s3}- ");
        Console.WriteLine($"IndexOf('bc'): -{n1}- ");
        Console.WriteLine($"LastIndexOf('bc'): -{n2}- ");
        Console.WriteLine($"Substring(3):{s4}");
        Console.WriteLine($"Substring(3,5):{s5}");
        Console.WriteLine($"Replace('a', 'x'):{s6}");
        Console.WriteLine($"Replace('abc', 'xy'):{s7}");
        Console.WriteLine($"IsNullOrEmpty(original):{b1}");
        Console.WriteLine($"IsNullOrWhiteSpace:{b2}");
    }
}