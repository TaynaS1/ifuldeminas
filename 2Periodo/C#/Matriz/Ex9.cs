using System;
using BibliotecaMatriz;
class Ex9
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
        for (int i = 0; i < valorL; i++)
        {
            int soma = 0;
            for (int j = 0; j < valorC; j++)
            {
                soma += valor[i, j];
            }
            Console.WriteLine($"Regiao {i + 1}: {soma} tropas");
        }
    }
}