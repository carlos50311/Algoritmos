﻿namespace CursoCsharp;

public class UsandoBreak
{
    public static void Executar()
    {
        Random random = new();
        int numero = random.Next(1, 51);
        Console.WriteLine("O numero que queremos é {0}!", numero);

        for (int i = 1; i < 50; i++)
        {
            Console.Write("{0} é o numero que queremos? ", i);
            if (i == numero)
            {
                Console.WriteLine("Sim");
                break;
            }
            else
            {
                Console.WriteLine("Não");
            }
        }
    }

}
