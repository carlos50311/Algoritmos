namespace CursoCsharp;

public class Membros
{
    public static void Executar()
    {
        Pessoa p1 = new();
        var p2 = new Pessoa();

        p1.Nome = "Renato";
        p1.Idade = 22;

        Console.WriteLine($"Prazer eu sou o {p1.Nome}, e tenho {p1.Idade} de idade!");

        p1.ApresentarNoConsole();

        p2.Nome = "Carlos";
        p2.Idade = 30;

        var apresentacaoP2 = p2.Apresentar();

        Console.WriteLine(apresentacaoP2);


    }
}
