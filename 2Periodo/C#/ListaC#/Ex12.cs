using System; 
class Ex12
{
    static void Main()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double[] notas = new double[5];
        for (int i = 0; i < 5; i++)
        {
            notas[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
        }
        double notaFinal = CalcularNotaFinal(notas);

        Console.WriteLine(notaFinal.ToString("F1", CultureInfo.InvariantCulture));
    }
    static double CalcularNotaFinal(double[] notas)
    {
        double maior = notas[0];
        double menor = notas[0];
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
            if (notas[i] > maior)
                maior = notas[i];
            if (notas[i] < menor)
                menor = notas[i];
        }
        return soma - maior - menor;
    }
}