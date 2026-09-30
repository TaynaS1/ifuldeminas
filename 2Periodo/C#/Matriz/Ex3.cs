using System;
using BibliotecaMatriz;
class Ex3
{
    static void diagonalP(int [,] matriz)
    {
       Console.Write("Diagonal principal:");
       int diagonal = matriz[0,0];
       for(int i = 0;i < matriz.GetLength(0) ;i++)
        {
            Console.Write($"{matriz[i,i]}");
        }

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
    }
}