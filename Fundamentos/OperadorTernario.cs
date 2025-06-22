namespace CursoCsharp;

public class OperadorTernario
{
    public static void Executar()
    {
        int nota = 7;
        string aprovado = nota >= 7 ? "Aprovado" : "Reprovado";
        Console.WriteLine(aprovado);
    }
}
