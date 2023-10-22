using System;
using System.Linq;

namespace Ex_matriz;

public static class Program
{
	public static void Main()
	{
		Random rand = new Random();
		Console.WriteLine("digite as dimensões das matrizes");
		string[] r = Console.ReadLine().Split();
		int[,] matrix = new int[Convert.ToInt32(r[0]),Convert.ToInt32(r[1])];
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{

				matrix[i, j] = rand.Next(1,10);
                Console.Write(matrix[i, j]+"  ");
			}
            Console.WriteLine();
		}
		Console.WriteLine("Digite um numero para ser buscado");
		int n = Convert.ToInt32(Console.ReadLine());
		Pega_valores(matrix, matrix.GetLength(1), n);


	}

	static void Pega_valores(int[,] arr,int colunas, int numero)
    {
		int cima = 0;
		int direita = 0;
		int esquerda = 0;
		int baixo = 0;
		int achou = 0;
		int[] res = { };


		for (int i = 0; i < arr.GetLength(0); i++)
        {
			for(int j = 0; j < arr.GetLength(1); j++)
            {
				if (arr[i, j] == numero)
				{
                    Console.WriteLine($"Position {i},{j}");
					if (j+1 < arr.GetLength(1)) //ver esse bug
					{
						direita = arr[i, j + 1];
                        Console.WriteLine($"Right:{direita}");

					}
					if (!(i-1 == -1))
					{
						cima = arr[i - 1, j];
                        Console.WriteLine($"Up:{cima}");
					}
					if (!(j== 0))
					{
						esquerda = arr[i, j - 1];
                        Console.WriteLine($"Left:{esquerda}");
					}
					if (!(i+1 == arr.GetLength(0)))
					{
						baixo = arr[i + 1, j];
                        Console.WriteLine($"Down:{baixo}");
					}
					Console.WriteLine();
				}
                
                
            }
        }

		
    }
}