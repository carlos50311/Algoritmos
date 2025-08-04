namespace CursoCsharp;

public class Produto
{
    public string Nome = String.Empty;
    public double Preco = 0.0;

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Produto outro)
        {
            return Nome == outro.Nome && Preco == outro.Preco;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Preco);
    }
}


public class ColecoesList
{
    public static void Executar()
    {
        var livro = new Produto("Game of Thrones", 49.0);
        var carrinho = new List<Produto>();
        carrinho.Add(livro);

        var combo = new List<Produto>
        {
            new Produto("Playstation 5", 5000.0),
            new Produto("Senhor dos aneis", 89.0),
            new Produto("Garrafa termica", 57.0)
        };

        carrinho.AddRange(combo);
        Console.WriteLine(carrinho.Count);
        carrinho.RemoveAt(3);

        foreach (var item in carrinho)
        {
            Console.Write(carrinho.IndexOf(item));
            Console.WriteLine($"{item.Nome} {item.Preco}");
        }
    }
}
