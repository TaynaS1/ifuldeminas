using System;

class Ex9
{
    static void Main()
    {
        char[] dna = new char[50];
        Console.Write("Quantas bases o DNA tem? ");
        int quantidade = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite a base " + (i + 1) + " (A, T, C ou G): ");
            string entrada = Console.ReadLine()!;
            dna[i] = entrada[0];
        }
        char[] complementar = new char[quantidade];
        for (int i = 0; i < quantidade; i++)
        {
            if (dna[i] == 'A')
                complementar[i] = 'T';
            else if (dna[i] == 'T')
                complementar[i] = 'A';
            else if (dna[i] == 'C')
                complementar[i] = 'G';
            else if (dna[i] == 'G')
                complementar[i] = 'C';
        }
        Console.Write("Fita original:      ");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(dna[i]);
        }
        Console.WriteLine();
        Console.Write("Fita complementar:   ");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(complementar[i]);
        }
        Console.WriteLine();
    }
}