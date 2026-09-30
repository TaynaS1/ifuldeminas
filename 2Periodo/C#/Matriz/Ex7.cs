using System;
using BibliotecaMatriz;
class Ex7
{
    static void SomarM(int[,] m1, int[,] m2)
    {
        int l1 = m1.GetLength(0);
        int c1 = m1.GetLength(1);
        int l2 = m2.GetLength(0);
        int c2 = m2.GetLength(1);
        if (l1 != l2 || c1 != c2)
        {
            Console.WriteLine("\nAs matrizes nao sao de mesma ordem.");
            return;
        }
        int[,] soma = new int[l1, c1];
        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                soma[i, j] = m1[i, j] + m2[i, j];
            }
        }
        Console.WriteLine("\nResultado da Soma:");
        Matriz.mostrarMatriz(soma);
    }
    static void Main()
    {
        Console.Write("Linhas da Matriz 1: ");
        int l1 = int.Parse(Console.ReadLine()!);
        Console.Write("Colunas da Matriz 1: ");
        int c1 = int.Parse(Console.ReadLine()!);
        int[,] mat1 = new int[l1, c1];
        Matriz.gerarMatriz(mat1);
        Console.Write("\nLinhas da Matriz 2: ");
        int l2 = int.Parse(Console.ReadLine()!);
        Console.Write("Colunas da Matriz 2: ");
        int c2 = int.Parse(Console.ReadLine()!);
        int[,] mat2 = new int[l2, c2];
        Matriz.gerarMatriz(mat2);
        Console.WriteLine("\nMatriz 1:");
        Matriz.mostrarMatriz(mat1);
        Console.WriteLine("\nMatriz 2:");
        Matriz.mostrarMatriz(mat2);
        SomarM(mat1, mat2);
    }
}
