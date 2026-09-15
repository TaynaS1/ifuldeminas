using System;
using System.IO;
class Ex2
{
    static void Main()
    {
        string[] linhas = File.ReadAllLines("ocorrencias.csv");
        bool[,] mapa= new bool[501, 501];
        int totalRaios= 0;
        int raioRepetido= 0;
        for (int y = 0; y < linhas.Length;y++)
        {
            string[] valores= linhas[y].Split(',');
            for (int x= 0; x< valores.Length;x++)
            {
                int quantidade = int.Parse(valores[x]);
                totalRaios += quantidade;
                if (quantidade > 1 ||(quantidade == 1&& mapa[x, y]))
                {
                    raioRepetido= 1;
                }
                if (quantidade > 0)
                {
                    mapa[x, y]= true;
                }
            }
        }
        Console.WriteLine($"Entrada: {totalRaios}");
        Console.WriteLine($"Saida: {raioRepetido}");
    }
}