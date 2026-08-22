using System;

class Ex1{
  static double calcularMedia(double nota1, double nota2, double nota3)
    {
        double resultado;
        resultado = (nota1 + nota2 + nota3) / 3;
        return resultado;
    }
    static void Main()
    {
        double nota1,nota2,nota3,resultado;
        Console.WriteLine("Entre com as 3 notas");
        nota1=double.Parse(Console.ReadLine()!);        
        nota2=double.Parse(Console.ReadLine()!);
        nota3=double.Parse(Console.ReadLine()!);
        resultado = calcularMedia(nota1, nota2, nota3);//chamando a função
        Console.WriteLine($"Média ponderada:{resultado:F2}");
    }
}
