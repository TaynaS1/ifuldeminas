using System;

class Roteiro2
{

    static void Main()
    {
        int[] numeros = new int[5];
        int busca;
        bool encontrou = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }
        // ler valor para busca
        Console.Write("Digite o valor a ser buscado: ");
        busca = int.Parse(Console.ReadLine()!);
        for (int i = 0; i <numeros.Length; i++)
        {
            if(busca == numeros[i])
            {
                Console.WriteLine($"VAlor encontrado na posição {i}");
                encontrou = true;
                break;
            }
        }
        if(!encontrou) //encontrou == false
        Console.WriteLine("Valor não encontrado");
        {
            Console.WriteLine("Valor não encontrado");
        }
        //mostrar dados
        Console.ReadKey();
    }
}