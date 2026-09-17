using System;
class Ex10
{
    static void Main()
    {
        Console.Write("Vezes que o dado foi lançado?: ");
        int n = int.Parse(Console.ReadLine());
        int[] lancamentos = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Resultado do lançamento {i + 1}: ");
            lancamentos[i] = int.Parse(Console.ReadLine());
        }
        int[] ocorrencias = ContarO(lancamentos);
        Console.Write("\nOcorrências de cada face:");
        for (int face = 1; face <= 6; face++)
        {
            Console.Write($"Face {face}: {ocorrencias[face - 1]} vezes");
        }
    }
    static int[] ContarO(int[] lancamentos)
    {
        int[] ocorrencias = new int[6];
        for (int i = 0; i < lancamentos.Length; i++)
        {
            int face = lancamentos[i];
            ocorrencias[face - 1] = ocorrencias[face - 1] + 1;
        }
        return ocorrencias;
    }
}