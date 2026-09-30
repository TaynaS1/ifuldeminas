using System;
using BibliotecaMatriz;
class Ex2
{
    static int MenorV(int[,] matriz)
    {
        int menor = matriz[0,0];
        for(int i = 0;i < matriz.GetLength(0); i++)
        {
            for(int j = 0;j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] < menor) menor = matriz[i,j];
            }
        }
        return menor;
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
        int resultado = MenorV(valor);
        Console.Write($"O menor valor:{resultado}");
    }
}