using System;
class Ex4
{
    static void Main()
    {
        Console.Write("Tamanho do vetor:");
        int n = int.Parse(Console.ReadLine()!);
        int[] num = new int[n];
        for(int i= 0;i < num.Length; i++)
        {
            Console.Write($"Valor da posição {i}:");
            num[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("\nValores: " + string.Join(", ", num));
        MenorV(num);
    }
    static void MenorV(int[] num)
    {
        int menorV = num[0];
        Console.Write("Menor valor:");
        for(int i= 0;i < num.Length; i++)
        {
            if(num[i] < menorV)
            {
                  menorV = num[i];
            }
        }
         Console.WriteLine(" " + menorV);
    }
}