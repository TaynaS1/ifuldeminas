using System;

class Ex6
{
    static void Main()
    {
        Console.Write("Número de linhas: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Numero de colunas: ");
        int m = int.Parse(Console.ReadLine()!);
        double[,] matrizA = new double[n, m];
        double[,] matrizB = new double[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Matriz A [{i},{j}]: ");
                matrizA[i, j] = double.Parse(Console.ReadLine()!);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Matriz B [{i},{j}]: ");
                matrizB[i, j] = double.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("(a) Somar as duas matrizes;\n(b) Subtrair a primeira matriz da segunda (B - A);\n(c) Adicionar uma constante às duas matrizes;\n(d) Imprimir as matrizes;\nEscolha uma opção: ");
        string opcao = Console.ReadLine()!.ToLower();
        switch (opcao)
        {
            case "a":
                Console.WriteLine("\nResultado da Soma (A + B)");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        double soma = matrizA[i, j] + matrizB[i, j];
                        Console.Write($"{soma}\t");
                    }
                    Console.WriteLine();
                }
                break;
            case "b":
                Console.WriteLine("\nResultado da Subtração (B - A)");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        double subtracao = matrizB[i, j] - matrizA[i, j];
                        Console.Write($"{subtracao}\t");
                    }
                    Console.WriteLine();
                }
                break;
            case "c":
                Console.Write("\nQual operação deve ser feita: ");
                double k = double.Parse(Console.ReadLine()!);
                Console.WriteLine("\nSoma final");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrizA[i, j] += k;
                        Console.Write($"{matrizA[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n Matriz B com a soma");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrizB[i, j] += k;
                        Console.Write($"{matrizB[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                break;
            case "d":
                Console.WriteLine("\n Matriz A");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{matrizA[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nMatriz B ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{matrizB[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}

