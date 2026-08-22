using System;
using BibliotecaFuncoes;
class Program
{ 

           static void Main()
        {
            int[] meuArray = new int[10];
            BibliotecaVetor.lerVetor(meuArray);
            BibliotecaVetor.mostrarVetor(meuArray);
            Console.ReadKey();
        }
           
    }


