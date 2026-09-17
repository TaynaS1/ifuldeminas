using System;
class Ex2
{
    static void Main()
    {
        Console.Write("Numeros de vetores:");
        int n = int.Parse(Console.ReadLine()!);
        int[] num = new int[n];
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Valor da posiçaõ:");
            num[i] = int.Parse(Console.ReadLine()!);
        } 
        Console.WriteLine("\nValores: " + string.Join(", ", num)); 
        valorImpar(num);
    }
    static void valorImpar(int[] num)
    {
        Console.Write("Valores Impares:");
        for(int i = 0; i < num.Length; i++)
        {
        if(num[i] % 2 != 0)
        {
           Console.Write(num[i] + " ");
        }
        }
    }   
}