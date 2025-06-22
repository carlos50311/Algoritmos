namespace CursoCsharp;

public class EstruturaDoWhile
{
    public static void Executar()
    {
        string? entrada = "";
        do
        {
            Console.Write("Digite um nome de usuario: ");
            entrada = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo {entrada}");
            Console.Write("Deseja continuar ? (S/N)");
            entrada = Console.ReadLine();
        } while (entrada.ToLower() == "s");
    }
}
