using System;

class Roteiro
{
    static void Main()
    {
        Console.Write("Digite o primeiro texto: ");
        string texto1 = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo texto: ");
        string texto2 = Console.ReadLine() ?? "";
        //Length
        Console.WriteLine("Tamanho do texto 1: " + texto1.Length);
        Console.WriteLine("Tamanho do texto 2: " + texto2.Length);
        //ToUpper
        string texto1Maiusculo = texto1.ToUpper();
        string texto2Maiusculo = texto2.ToUpper();

        Console.WriteLine("Texto 1 em maiúsculas: " + texto1Maiusculo);
        Console.WriteLine("Texto 2 em maiúsculas: " + texto2Maiusculo);
        //string.Compare()
        int comparacao = string.Compare(texto1Maiusculo, texto2Maiusculo);

        if (comparacao == 0)
            Console.WriteLine("Os textos são equivalentes.");
        else
            Console.WriteLine("Os textos NÃO são equivalentes.");
    }
}