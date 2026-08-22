using System;

class Program2
{     
    static void leiaVetor(int[] lerVetor)
    {
         Console.WriteLine("Entre com os dados do vetor:");
        for(int i=0;i < lerVetor.Length;i++)
        {
        Console.Write($"Array[{i}]:");
        lerVetor[i] = int.Parse(Console.ReadLine());
        }

    }
    static void gerarVetor(int[] vetor)
    {
        Random aleatorio =  new Random();
        for(int i=0; i < vetor.Length;i++)
        {
            vetor[i] = aleatorio.Next(1,100);
        }

    }
    static void mostraVetor(int[] vetor)
    {
         Console.WriteLine("[Funcao]Dados do Vetor");
        for(int i=0; i < vetor.Length;i++)
        Console.Write("|" + vetor[i]);

        Console.WriteLine("|");

    }
    static void Main()
    {
        int[] meuArray = new int[5];
        gerarVetor(meuArray);
        mostraVetor(meuArray);
    }

}