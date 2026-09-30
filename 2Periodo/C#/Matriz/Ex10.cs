using System;
using BibliotecaMatriz;
class Ex10
{
    static void Main()
    {
        Console.Write("Numeros de linhas:");
        int valorL = int.Parse(Console.ReadLine()!);
        Console.Write("Numeros de colunas:");
        int valorC = int.Parse(Console.ReadLine()!);
        int[,] valor = new int[valorL, valorC];
        Matriz.gerarMatriz(valor);
        Matriz.mostrarMatriz(valor);
        int areaTotal = 0;
        for (int i = 0; i < valorL; i++)
        {
            for (int j = 0; j < valorC; j++)
            {
                if (valor[i, j] > 0)
                {
                    areaTotal++;
                }
            }
        }
        Console.WriteLine(areaTotal);
    }
}