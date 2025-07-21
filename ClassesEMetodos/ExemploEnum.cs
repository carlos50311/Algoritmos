namespace CursoCsharp;

public enum Genero{Acao, Aventura, Terror, Animacao, Comedia}

public class Filme
{
    public string Titulo;
    public Genero GeneroDoFilme;
}

public class ExemploEnum
{
    public static void Executar()
    {
        int id = (int)Genero.Animacao;
        Console.WriteLine(id);

        Filme FilmeParaFamilia = new();
        FilmeParaFamilia.Titulo = "Sharknado 17";
        FilmeParaFamilia.GeneroDoFilme = Genero.Comedia;

        Console.WriteLine("{0} {1}", FilmeParaFamilia.Titulo, FilmeParaFamilia.GeneroDoFilme);
    }
}
