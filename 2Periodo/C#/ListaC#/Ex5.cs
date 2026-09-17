using System;
class Ex5
{
    static void Main()
    {
        int[] num = new int[10];
        gerarV(num, num.Length);
        int resultado = digValor(num);
        if (resultado != -1)
            Console.WriteLine($"Valor encontrado na posição {resultado}");
        else
            Console.WriteLine("Valor não encontrado no vetor.");
    }
    static void gerarV(int[] vet, int n)
    {
        int[] num = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vet[i] = rand.Next(1, 100);
            Console.Write(vet[i] + " ");
            Console.WriteLine();
        }
    }
    static int digValor(int[] num)
    {
        Console.Write("Valor de vetor que procura:");
        int valor = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == valor)
                return i;
        }
        return -1;
    }
}