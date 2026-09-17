using System;
class Ex8
{
    static void Main()
    {
        Console.Write("Quantos caracteres o vetor?: ");
        int n = int.Parse(Console.ReadLine());
        char[] vetor = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Caractere da posição {i}: ");
            vetor[i] = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine("\nVetor lido:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        char[] invertido = Inverter(vetor);
        Console.WriteLine("\nVetor invertido:");
        for (int i = 0; i < invertido.Length; i++)
        {
            Console.Write(invertido[i] + " ");
        }
    }
    static char[] Inverter(char[] vetor)
    {
        int n = vetor.Length;
        char[] resultado = new char[n];
        for (int i = 0; i < n; i++)
        {
            resultado[i] = vetor[n - 1 - i];
        }
        return resultado;
    }
}