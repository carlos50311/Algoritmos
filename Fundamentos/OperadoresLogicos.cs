﻿namespace CursoCsharp;

public class OperadoresLogicos
{
    public static void Executar()
    {
        var executouTrabalho1 = true;
        var executouTrabalho2 = false;

        var comprouTv50 = executouTrabalho1 && executouTrabalho2;
        Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

        var comprouSorvete = executouTrabalho1 || executouTrabalho2;
        Console.WriteLine("Comprou o sorvete {0}", comprouSorvete);

        var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
        Console.WriteLine("comprou a Tv32 {0}", comprouTv32);

        Console.WriteLine("Mais saudavel {0}", !comprouSorvete);
    }
}
