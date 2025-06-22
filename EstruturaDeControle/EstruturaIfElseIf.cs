namespace CursoCsharp;

public class EstruturaIfElseIf
{
    public static void Executar()
    {
        string? entrada = "";

        Console.Write("Qual e o valor da nota?");
        entrada = Console.ReadLine();
        double.TryParse(entrada, out double nota);

        if (nota >= 9.0)
        {
            Console.WriteLine("Quadro de Honra!");
        }
        else if (nota >= 7.0)
        {
            Console.WriteLine("Aprovado!");
        }
        else if (nota >= 5.0)
        {
            Console.WriteLine("Receuperação!");
        }
        else
        {
            Console.WriteLine("No vemos numa proxima ..."); 
        }

    }
}
