using System;
using BibliotecaFuncoes;

class Ex2
{
    static int ContarImpares(int[] vetor)
    {
        int ContadorImpares = 0;
        for (int i = 0; i < vetor.Length; i++)
            if (vetor[i] % 2 != 0)
                ContadorImpares++;
        return ContadorImpares;

    }
    static void Main()
    {
        int n;
        Console.Write("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine()!);
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);
        Console.WriteLine($"\nQuantidade de impares:{ ContarImpares(meuArray)}");
        Console.ReadKey();
    }
}