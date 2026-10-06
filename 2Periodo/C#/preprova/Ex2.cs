using System;
using System.IO;
using BibliotecaMatriz;
class Ex2
{
    static double[] calcularPercentuaDesmatamento(int[,] matriz)
    {
        double[] contagem = new double[3];
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
                contagem[matriz[i, j]]++;
        for (int k = 0; k < 3; k++)
            contagem[k] = contagem[k] / 36 * 100;
        return contagem;
    }
    static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
    {
        double anterior = calcularPercentuaDesmatamento(matrizAnterior)[0];
        double atual = calcularPercentuaDesmatamento(matrizAtual)[0];
        Console.WriteLine("Percentual de ocorrências na matriz 6 meses atrás:");
        Console.WriteLine($"Área Desmatada (Código 0): {anterior:F2}%");
        Console.WriteLine("Percentual de ocorrências na matriz atual:");
        Console.WriteLine($"Área Desmatada (Código 0): {atual:F2}%");
        if (atual > anterior)
            Console.WriteLine($"Houve Aumento no Desmatamento - Anterior {anterior:F2}% -> Atual {atual:F2}%");
        else if (atual < anterior)
            Console.WriteLine($"Houve Redução no Desmatamento - Anterior {anterior:F2}% -> Atual {atual:F2}%");
        else
            Console.WriteLine("O desmatamento não mudou");
    }
    static void Main()
    {
        string arquivoAnterior = "dados_matriz_6meses_atras.csv";
        string arquivoAtual = "dados_matriz_atual.csv";
        if (!File.Exists(arquivoAnterior) || !File.Exists(arquivoAtual))
        {
            Console.WriteLine("Arquivo CSV não encontrado.");
            return;
        }
        int[,] anterior = Matriz.carregarMatriz(arquivoAnterior);
        int[,] atual = Matriz.carregarMatriz(arquivoAtual);
        Console.WriteLine("Matriz 6 meses atrás:");
        Matriz.mostrarMatriz(anterior);
        Console.WriteLine("Matriz atual:");
        Matriz.mostrarMatriz(atual);
        analisarAumento(anterior, atual);
    }
}