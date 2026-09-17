using System;
class Ex11
{
    static void Main()
    {
        Console.Write("Mensagem codificada:");
        string mensagem = Console.ReadLine();
        string decodificada = Decodificar(mensagem);
        Console.WriteLine(decodificada);
    }
    static string Decodificar(string mensagem)
    {
        string resultado = "";
        int i = 0;
        while (i < mensagem.Length)
        {
            if (mensagem[i] == ' ')
            {
                resultado += ' ';
                i++;
            }
            else
            {
                resultado += mensagem[i + 1];
                i += 2;
            }
        }
        return resultado;
    }
}