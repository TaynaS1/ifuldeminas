using System;
using BibliotecaMatriz;
 public class Ex1
{ 
    public static void Main()
    {   //leitura da matrix
        Console.Write("Números de linhas:");
        int linha= int.Parse(Console.ReadLine()!);
        Console.Write("Números de colunas: ");
        int coluna = int.Parse(Console.ReadLine()!);
        
        int[,] matriz = new int[linha,coluna];
        Matriz.gerarMatriz(matriz);
        Console.Write("\nMatriz:");
        Matriz.mostrarMatriz(matriz);
        //maior valor
        int maior = matriz[0,0];
        int linhaMaior = 0;
        int colunaMaior = 0;
        for(int i =0;i< linha; i++)
        {
          for(int j = 0; j < coluna; j++)
            {
              if(matriz[i,j]> maior)
                {
                    maior = matriz[i,j];
                    linhaMaior = i;
                    colunaMaior= j;
                }
            }
        }
        Console.WriteLine($"\nMaior valor:{maior}");
    }
}
