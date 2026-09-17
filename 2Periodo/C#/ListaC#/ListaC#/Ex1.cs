using System;
class Ex1
{
    static void Main()
    {
        Console.Write("Numeros de vetores:");
        int n = int.Parse(Console.ReadLine()!);
        int[] num = new int[n];
        int soma = 0;
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Valor da posiçaõ:");
            num[i] = int.Parse(Console.ReadLine()!);
            soma += num[i];
        } 
        Console.WriteLine("\nValores: " + string.Join(", ", num));  
        Console.WriteLine($"Soma dos elementos: {soma}");
    }
}
