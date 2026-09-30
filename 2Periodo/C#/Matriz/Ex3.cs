using System;
using BibliotecaMatriz;
class Ex3
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
        Console.Write("Diagonal principal:");
        int diagonal = valor[0,0];
        for(int i = 0;i < valor.GetLength(0) ;i++)
        {
            Console.Write($"{valor[i,i]}|");
        }
    }
}