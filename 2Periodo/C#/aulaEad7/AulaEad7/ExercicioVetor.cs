using System;
class ExercicioVetor
{
    static void Main()
    {
        string[]cidades ={"Campinas","Ribeirão Preto","São José dos Campos","Sorocaba","Bauru","Piracicaba","Jundiaí","Franca","São José do Rio Preto","Araraquara","Marília","Presidente Prudente","Botucatu","Limeira","Taubaté","Itu","Bragança Paulista","Mogi Guaçu","Catanduva","Jaú"};
        int[]casos = new int[cidades.Length];
        for(int i = 0;i < cidades.Length; i++)
        {
           Console.WriteLine($"Casos em {cidades[i]}");
           casos[i] =int.Parse(Console.ReadLine()!);
        }
        bool avaliar = acimaMedia(casos,cidades);
        if(avaliar)
        Console.WriteLine("Retorno:True(Há cidade acima da media)");
        else
        Console.WriteLine("Retorno:False (Nunhuma cidade aci9ma da media)");
    }
    static bool acimaMedia(int[] casos,string[] cidades)
    {
        if(casos.Length == 0);
        int soma=0;
        for(int i = 0;i<casos.Length;i++)
        soma+= casos[i];
        double media = (int)soma/casos.Length;
        Console.WriteLine($"Media de casos por cidades:{media.ToString("f2")}");
        bool avaliar = false;
        for(int i = 0; i< casos.Length; i++)
        {
            if (casos[i] > media)
            {
                Console.WriteLine($"Cidades que tem casos acma da media:\nÍndice: {i} | Cidade: {cidades[i]} | Casos: {casos[i]}");
                
            }
        }
        return avaliar;
    } 
}