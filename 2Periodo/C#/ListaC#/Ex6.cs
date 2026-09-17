using System;

class Ex6
{
    static void Main()
    {
        int[] num = new int[10];
        int[] num2 = new int[10];
        gerarV(num, num.Length);
        gerarV2(num2, num2.Length);
        int soma1 = SomarV(num);
        int soma2 = SomarV(num2);
        Console.WriteLine($"\n Multiplicação dos vetores 1: {soma1}");
        Console.WriteLine($"multiplicação dos vetores 2: {soma2}");
        Console.WriteLine($"Total: {soma1 + soma2}");
    }
    static void gerarV(int[] vet, int n)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vet[i] = rand.Next(1, 100);
            Console.Write(vet[i] + " ");
        }
        Console.WriteLine();
    }
    static void gerarV2(int[] vet, int n)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vet[i] = rand.Next(1, 100);
            Console.Write(vet[i] + " ");
        }
        Console.WriteLine();
    }
    static int SomarV(int[] num)
    {
        int mult = 1;
        for (int i = 0; i < num.Length; i++)
        {
            mult *= num[i];
        }
        return mult;
    }
}