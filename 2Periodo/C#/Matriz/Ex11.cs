using System;
using BibliotecaMatriz;
class Ex11
{
        static void Main()
    {
        Console.Write("Numeros de linhas:");
        int valorL = int.Parse(Console.ReadLine()!);
        Console.Write("Numeros de colunas:");
        int valorC = int.Parse(Console.ReadLine()!);
        int[,] valor = new int[valorL, valorC];
        Matriz.gerarMatriz(valor);
        Matriz.mostrarMatriz(valor);
        int somaPrincipal = 0;
        int somaSecundaria = 0;
        for (int i = 0; i < valorL; i++)
        {
            somaPrincipal += valor[i, i];
            somaSecundaria += valor[i, valorL - 1 - i];
        }
        Console.WriteLine($"\nSoma da Diagonal Principal: {somaPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundaria: {somaSecundaria}");

        if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("\nO maior tesouro esta na diagonal principal, vamos para la!");
        }
        else if (somaSecundaria > somaPrincipal)
        {
            Console.WriteLine("\nO maior tesouro esta na diagonal secundaria, vamos para la!");
        }
        else
        {
            Console.WriteLine("\nAmbas as diagonais possuem a mesma quantidade de moedas!");
        }
    }
}