using System;
using BibliotecaMatriz;
class Ex4
{
    static void Main()
    {
        Console.Write("Numeros de linhas:");
        int valorL = int.Parse(Console.ReadLine()!);
        Console.Write("Numeros de colunas:");
        int valorC = int.Parse(Console.ReadLine()!);
        int[,] valor = new int [valorL,valorC];
        Matriz.gerarMatriz(valor);
        Matriz.mostrarMatriz(valor);
        Console.Write("Diagonal segundário:");
        int diagonalS = valor.GetLength(1);
        for(int i = 0;i < valor.GetLength(0); i++)
        {
            Console.Write($"{valor[i, diagonalS - 1 - i]}|");
        }
    }
}