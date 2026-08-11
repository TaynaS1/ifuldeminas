using System;

class Ex1
{
    static void LeiaVetor(int[] vetor)
    {
        Console.WriteLine("Entre com os dados do vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void MostraVetor(int[] vetor)
    {
        Console.WriteLine("[Função] Dados do Vetor:");
        Console.WriteLine("|" + string.Join("|", vetor) + "|");
    }
    static int SomaVetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    }

    static void Main()
    {
        Console.Write("Digite quantos elementos o vetor vai ter: ");
        int n = int.Parse(Console.ReadLine());

        int[] meuArray = new int[n];

        LeiaVetor(meuArray);
        MostraVetor(meuArray);
        int somaTotal = SomaVetor(meuArray);
        Console.WriteLine("A soma dos elementos do vetor é: " + somaTotal);
    }
}