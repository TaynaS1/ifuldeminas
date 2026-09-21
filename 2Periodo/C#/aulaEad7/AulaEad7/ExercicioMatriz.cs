using System;
using System.IO;
class ExercicioMatriz
{
    static string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho","Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
    static void Main()
    {
        int[,] matriz = new int[12,20];
        string[]linha = File.ReadAllLines("dados_incendios.csv");
        for(int i = 0; i < 20; i++)
        {
            string[]partes = linha[i].Split(',');
            for(int j= 0; j < 20; j++)
            {
                matriz[i,j]= int.Parse(partes[j]);
            }
        }
       int total= somaTotal(matriz);
       Console.WriteLine("Soma das ocorencias:"+total);
       mediaMes(matriz);
       maiorOc(matriz);
    }
        static int somaTotal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
    static void mediaMes(int[,] matriz)
    {
        double maiorMedia = 0;
        int mesMaior = 0;
        for (int i = 0; i < 12; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 20; j++)
            {
                somaLinha += matriz[i, j];
            }
            double media = somaLinha / 20.0;
            if (media > maiorMedia)
            {
                maiorMedia = media;
                mesMaior = i;
            }
        }
        Console.WriteLine("Mês de maior média de ocorrências:");
        Console.WriteLine(meses[mesMaior] + " (média: " + maiorMedia.ToString("F1") + ")");
    }
    static void maiorOc(int[,] matriz)
    {
        int maior = matriz[0, 0];
        int linhaMaior = 0;
        int colunaMaior = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                    linhaMaior = i;
                    colunaMaior = j;
                }
            }
        }
        Console.WriteLine("Onde ocorreu a maior quantidade de ocorrências: [" + linhaMaior + "," + colunaMaior + "]");
        Console.WriteLine(meses[linhaMaior] + " (coluna " + colunaMaior + ", ocorrências: " + maior + ")");
    }
}