using System;

class Ex7
{
    static void Main()
    {
        Console.Write("Quantos números o vetor terá? ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("\nOs elementos do vetor são:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
        Console.Write("\nDigite o valor que deseja procurar: ");
        int valorProcurado = int.Parse(Console.ReadLine());
        int quantasVezes = Contar(vetor, valorProcurado);
        Console.WriteLine($"O valor {valorProcurado} aparceu {quantasVezes} vezes no vetor.");
    }
    static int Contar(int[] vetor, int valorP)
    {
        int cont = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorP)
            {
                cont += cont + 1;
            }
        }
        return cont;
    }
}