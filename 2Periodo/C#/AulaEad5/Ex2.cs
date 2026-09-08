using System;
using BibliotecaMatriz;
 public class Ex2
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
        int menor = matriz[0,0];
        int linhaMenor = 0;
        int colunaMenor = 0;
        for(int i =0;i< linha; i++)
        {
          for(int j = 0; j < coluna; j++)
            {
              if(matriz[i,j]< menor)
                {
                    menor = matriz[i,j];
                    linhaMenor = i;
                    colunaMenor= j;
                }
            }
        }
        Console.WriteLine($"\nMenor valor:{menor}");
    }
}