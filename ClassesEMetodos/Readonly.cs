namespace CursoCsharp;

public class Cliente
{
    public string Nome;

    //Transforma o atributo e um atributo imutavel, estamos falando do readonly
    readonly DateTime Nascimento;

    public Cliente(string nome, DateTime nascimento)
    {
        Nome = nome;
        Nascimento = nascimento;
    }

    public Cliente()
    {

    }

    public string GetDataDeNascimento()
    {
        return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
    }
}

public class Readonly
{
    public static void Executar()
    {
        Cliente cliente = new("Carlos", new DateTime(2002, 10, 01));
        Console.WriteLine(cliente.Nome);
        Console.WriteLine(cliente.GetDataDeNascimento());

        var novoCliente = new Cliente();

        novoCliente.Nome = "Maria";

        Console.WriteLine(novoCliente.Nome);

    }
}
