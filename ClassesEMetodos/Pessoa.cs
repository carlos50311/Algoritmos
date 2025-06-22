namespace CursoCsharp;

public class Pessoa
{
    public string? Nome;
    public int Idade;

    public string Apresentar()
    {
        return string.Format("Olá, meu nome é {0} e tenho {1} anos de idade", Nome, Idade);
    }

    public void ApresentarNoConsole()
    {
        Console.WriteLine(Apresentar());
    }
}
