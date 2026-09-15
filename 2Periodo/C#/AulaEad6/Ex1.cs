using System;
class Ex1
{
    static void Main()
    {
        int linha = 3;
        int coluna = 4;
        int[,] matriz = new int[linha, coluna];
        Random random = new Random();

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz[i, j] = random.Next(1, 100);
            }
        }
        exibirMatriz(matriz);
        somarForca(matriz);
    }
    static void exibirMatriz(int[,] matriz)
    {
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                Console.Write($"{matriz[i, j]}");
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }
    static void somarForca(int[,] matrizTropas)
    {
        int R = matrizTropas.GetLength(0);
        int C = matrizTropas.GetLength(1);
        Console.WriteLine("Força por região");
        for (int i = 0; i < R; i++)
        {
            int somaRegiao = 0;
            for (int j = 0; j < C; j++)
            {
                somaRegiao = somaRegiao + matrizTropas[i, j];
                Console.Write($"{matrizTropas[i, j]}|");
            }
            Console.WriteLine();
            Console.WriteLine($"Força Total da Região {i + 1}:{somaRegiao} tropas\n");
        }
    }
}