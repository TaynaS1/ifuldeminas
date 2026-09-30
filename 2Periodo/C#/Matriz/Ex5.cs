using System;
using BibliotecaMatriz;
class Ex5
{
    static int ContarO(int[,] matriz,int x)
    {
        int cont = 0;
        for(int i = 0;i < matriz.GetLength(0); i++)
        {
            for(int j =0;j< matriz.GetLength(1); j++)
            {
                if(matriz[i,j] == x) cont++;
            }
        }
        return cont;
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
        Console.Write("Número para avaliar:");
        int numeroP = int.Parse(Console.ReadLine()!);
        int qdt = ContarO(valor, numeroP);
        Console.WriteLine($"O número {numeroP} aparece {qdt} vezes.");
    }
}