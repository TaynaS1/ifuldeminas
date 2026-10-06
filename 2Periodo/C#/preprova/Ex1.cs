using System;
class Vetor
{
    static double calcularM(int[] roubos)
    {
        double soma = 0;
        for (int i = 0; i < roubos.Length; i++)
            soma += roubos[i];
        return soma / roubos.Length;
    }
    static void bairrosViolentos(string[] bairros, int[] roubos)
    {
        bool[] usado = new bool[roubos.Length];

        Console.WriteLine("Os 3 bairros mais violentos:");
        for (int lugar = 1; lugar <= 3; lugar++)
        {
            int maior = -1;
            for (int i = 0; i < roubos.Length; i++)
            {
                if (!usado[i] && (maior == -1 || roubos[i] > roubos[maior]))
                    maior = i;
            }
            usado[maior] = true;
            Console.WriteLine($"{lugar}º Lugar: {bairros[maior]} (Índice {maior}) - {roubos[maior]} roubos");
        }
    }
     static void Main()
    {
        string[] bairros = { "Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé",
            "Santo Amaro", "Vila Mariana", "Lapa", "Capão Redondo", "Santana" };
        int[] roubos = { 350, 120, 210, 480, 190, 310, 150, 280, 520, 240 };
        Console.WriteLine("Analise de segurança pública");
        Console.WriteLine($"Média de roubos por bairro: {calcularM(roubos):F2} ocorrências");
        bairrosViolentos(bairros, roubos);
    }
}