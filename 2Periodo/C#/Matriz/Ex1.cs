using System;
using BibliotecaMatriz;
class Ex1
{
    static int MaiorV(int[,] matriz)
    {
        int maior = matriz[0,0];
        for(int i = 0;i < matriz.GetLength(0); i++)
        {
            for(int j = 0;j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] > maior) maior = matriz[i,j];
            }
        }
        return maior;
    }
   static void Main()
    {
        Console.Write("Numeros de linhas:");
        int valorL = int.Parse(Console.ReadLine()!);
        Console.Write("Numeros de colunas:");
        int valorC = int.Parse(Console.ReadLine()!);
        int[,] valor = new int [valorL,valorC];
        Matriz.gerarMatriz(valor);
        Matriz.mostrarMatriz(valor);
        int resultado = MaiorV(valor);
        Console.Write($"O maior valor:{resultado}");
    }
}