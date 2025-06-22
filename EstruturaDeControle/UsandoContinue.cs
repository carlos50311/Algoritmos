namespace CursoCsharp;

public class UsandoContinue
{
    public static void Executar()
    {
        int intervalo = 50;

        for (int i = 1; i < intervalo; i++)
        {
            if (i % 2 == 1)
                continue;

            Console.Write(i + " ");
        }

        for (int i = 2; i < intervalo; i += 2)
        {
            Console.Write(i);
        }
    }
}
