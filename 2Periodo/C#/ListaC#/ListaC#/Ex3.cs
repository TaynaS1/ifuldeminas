using System;
class Ex3
{
    static void Main()
    {
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
            mValor(num);
        }
    }
    static void mValor(int[] num)
    {
        int mValor = num[0];
        Console.Write("Maior Valor:");
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > mValor)
            {
                mValor = num[i];
            }
        }
         Console.WriteLine(" " + mValor);
    }
}