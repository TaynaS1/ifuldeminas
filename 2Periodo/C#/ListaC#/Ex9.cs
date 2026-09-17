using System;
class Ex9
{
    static void Main()
    {
        Console.Write("Quantas bases o DNA tem? ");
        int n = int.Parse(Console.ReadLine());
        char[] dna = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Base da posição {i} (A, T, C ou G): ");
            dna[i] = Convert.ToChar(Console.ReadLine().ToUpper());
        }
        Console.WriteLine("\nFita de DNA:");
        for (int i = 0; i < dna.Length; i++)
        {
            Console.Write(dna[i] + " ");
        }
        char[] complementar = GerarC(dna);
        Console.WriteLine("\nFita complementar:");
        for (int i = 0; i < complementar.Length; i++)
        {
            Console.Write(complementar[i] + " ");
        }
        Console.WriteLine();
    }
    static char[] GerarC(char[] dna)
    {
        char[] resultado = new char[dna.Length];
        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 'A')
                resultado[i] = 'T';
            else if (dna[i] == 'T')
                resultado[i] = 'A';
            else if (dna[i] == 'C')
                resultado[i] = 'G';
            else if (dna[i] == 'G')
                resultado[i] = 'C';
        }
        return resultado;
    }
}