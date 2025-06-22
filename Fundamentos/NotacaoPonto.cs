namespace CursoCsharp;

public class NotacaoPonto
{
    public static void Executar()
    {
        string saudacao = "ola".ToUpper().Insert(3, "World!").Replace("world!", "Mundo!");
        Console.WriteLine(saudacao);

        Console.WriteLine("Teste".Length);

        string? vaorImportante = null;
        Console.WriteLine(vaorImportante?.Length);
        
    }
}
